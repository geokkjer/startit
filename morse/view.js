function updateView(){
    app.innerHTML = '<input type="text" onchange="lettersFromInput=this.value"><button onclick="translator(lettersFromInput)">Button</button>';
    
}