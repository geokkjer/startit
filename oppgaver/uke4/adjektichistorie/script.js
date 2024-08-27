// Model Variabler
let sentence = ""
let words = ["Green", "Red", "Cat", "Man", "Started", "Jumped", "Pool", "Wall"];

// View
// HTML, onclick CSS
updateView();
function updateView() {
    let html = `
    <div id="sentence" class="sentence">Her er __ noe<br></div>
    <div id="buttons" class="buttons">
     <div onclick="insertWords(words[0])">${words[0]}</div><button onclick="insertWords(words[0])">${words[1]}</button>
     <button onclick="insertWords(words[0])">${words[2]}</button><button onclick="insertWords(words[0])">${words[3]}</button>
     <button onclick="insertWords(words[0])">${words[4]}</button><button onclick="insertWords(words[0])">${words[5]}</button>
     <button onclick="insertWords(words[0])">${words[6]}</button><button onclick="insertWords(words[0])">${words[7]}</button>
     </div>`;
    document.getElementById('app').innerHTML = html;
    
};

//  Controller endrer modellen
function insertWords(word) {
    document.getElementById('sentence').innerHTML = `annet ${word}`;

} 