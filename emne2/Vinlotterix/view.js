
function createMenu(){
    return /*html*/ `
    <button onclick="updateViewHome()">Home</button>
    <button onclick="showWinnersView()">Trekk vinnere</button>
    <button onclick="updateViewRules()">Sett opp regler for trekningen</button>
    <button onclick="updateViewList()">Vis tidligere trekkinger</button>
    <br/>
    `;
}

function updateViewHome(){
    document.getElementById('app').innerHTML = /*HTML*/ `
    <h1>Hello World!</h1>
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

function updateViewList(){
    let html = '';
    const employees = model.employees;
    for (let i = 0; i < employees.length; i++){
        const person = employees[i];
        html += /*html*/ `
        <li>${person.name}</li>
        `;
    }
    app.innerHTML = html + 'This is the list <button onclick="updateViewHome()">Home</button>'
}

function showWinnersView(){
    let winners = [];
    let num = model.input.rules.numWinners;

    for (i = 0; i < num; i++){
        index = Math.floor(Math.random() * (model.employees.length));
        console.log(index)
        winners.push(model.employees[index])
    }
    for (i = 0; i < winners.length; i++){
        app.innerHTML += /*html*/ `
        <h4>${winners[i].name}</h4>
    `; console.log(winners[i].name)}
    
}