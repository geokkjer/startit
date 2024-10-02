
function createMenu(){
    return /*html*/ `
    <button onclick="updateViewHome()">Hjem</button>
    <button onclick="showWinnersView()">Trekk vinnere</button>
    <button onclick="updateViewRules()">Sett opp regler for trekningen</button>
    <button onclick="editList()">Legg til/fjern</button>
    <br/>
    <hr>
    `;
}

function updateViewHome(){
    document.getElementById('app').innerHTML = /*HTML*/ `
    <h1>Velkommen til Vinlotterix</h1>
    ${createMenu()}
    `;
}

function updateViewRules(){
    app.innerHTML = /*HTML*/ `
    <h2>Hello from rules</h2> 
    ${createMenu()}
    <label for="model.input.rules.numWinners">Hvor mange vinnere?</label>
    <input type="number" 
        onchange="model.input.rules.numWinners=this.value" 
        min="0" 
        max="10"
        value="${model.input.rules.numWinners || ''}" 
        name="NumberOfWinners"></select>   
    <ol>
        <li>Nummer: ${model.input.rules.numWinners}</li>
    </ol>
    <button onclick="setRules()">Sett regler</button><br>
    `;
   
}

function editList(){
    let html = '';
    const employees = model.employees;
    for (let i = 0; i < employees.length; i++){
        const person = employees[i];
        html += /*html*/ `
        <li>${person.id}${person.name}<button onclick="goToEditPage(${person.id})">Edit</button></li>
        `;
    }
    app.innerHTML = html + 'This is the list <button onclick="updateViewHome()">Home</button>'
}

function showWinnersView(){
    let winners = [];
    let num = model.input.rules.numWinners;
    app.innerHTML = /*html*/ `<h1>Vinlotterix</h1><br> ${createMenu()}
    <h3>Vinnere:</h3>
    `;
    for (i = 0; i < num; i++){
        index = Math.floor(Math.random() * (model.employees.length));
        winners.push(model.employees[index]);
    }
    for (i = 0; i < winners.length; i++){
        app.innerHTML += /*html*/ `
        <h4>${winners[i].name}</h4>
    `;}
    
}

function goToEditPage(id){
    const person = model.employees[id];
    let newPerson = '';
    app.innerHTML = /*html*/ `
        
        <h1>Endre eller slett</h1><br> ${createMenu()}

        Navn: <input value="${person.name}" onchange="newPerson=this.value" /><button onclick="changeList(${person.id}, newPerson)">Send inn</button><br>
    `;
    
}

function changeList(id,name){
    console.log(id,name)
    model.employees[id].name = name;
    console.log(model.employees[id].name)
}