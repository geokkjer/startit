function updateView(){
    app.innerHTML = /*html*/ `
    <input type="text" onchange="lettersFromInput=this.value"><button onclick="translator(lettersFromInput)">Button</button>
    `;

    
}