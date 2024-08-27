// Model Variabler
let sentence = ""
let words = ["Green", "Red", "Cat", "Man", "Started", "Jumped", "Pool", "Wall"];

// View
// HTML, onclick CSS
updateView();
function updateView() {
    document.getElementById('app').innerHTML = 'Dette er ____';
    document.getElementById('app').innerHTML = /*HTML*/ `
     <button>${words[0]}</button><button>${words[1]}</button>
     <button>${words[2]}</button><button>${words[3]}</button>
     <button>${words[4]}</button><button>${words[5]}</button>
     <button>${words[6]}</button><button>${words[7]}</button>
     `;
};

//  Controller endrer modellen
function insertWords() {

} 