const page = model.app.currentPage;

function updateView(){
    if (page == "home"){
        viewhome();
    } else if (page == 'new'){
        viewNew();
    }
}
function viewhome(){
    navbar();
    document.getElementById('mainView').innerHTML = /*html*/ `
    <h1>Hello from Home</h1>
   
    `;
    // mainHtml.innerHTML += 'Hello'
   
}

function navbar(){
    document.getElementById('header').innerHTML = /*html*/ `
    <ul>
        <li><div onclick="goNew()">Books R Us</div></li> 
        <li>Søk: <input type="text"></li>
    </ul>`;
}
function viewNew(){
    navbar();
    document.getElementById('mainView').innerHTML = '<h1>Hello from new</h1>'
}
function goNew(){
    model.app.currentPage = 'new';
    updateView();
}
function dialog() {
    document.getElementById('mainView'),innerHTML += /*html*/ `
    <form method="dialog">
    <button type="button" id="dialog-trigger">Show me!</button>
    <dialog id="dialog"><p>Ansewer the question</p>
        <menu>
            <button value="1">1</button>
        </menu>
    </form>
    `;
}