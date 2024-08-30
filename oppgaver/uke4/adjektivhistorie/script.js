// Model Variabler

let words = ["green", "red", "cat", "man", "stared", "jumped", "pool", "wall"];
let word1 = '__ ';
let word2 = '__ ';
let word3 = '__ ';
let word4 = '__ ';
let sentence = "Once there was " + word1 + " " + word2 + " that " + word3 + " in the " + word4 + " - and great things happened. The End";
// View
// HTML, onclick CSS
updateView();
function updateView() {
    let html = `
    <div id="sentence" class="sentence">${sentence}<br></div>
    <div id="buttons" class="buttons">
     <div class="button" onclick="insertWords1(words[0])">${words[0]}</div>
     <div class="button" onclick="insertWords1(words[1])">${words[1]}</div>
     <div class="button" onclick="insertWords2(words[2])">${words[2]}</div>
     <div class="button" onclick="insertWords2(words[3])">${words[3]}</div>
     <div class="button" onclick="insertWords3(words[4])">${words[4]}</div>
     <div class="button" onclick="insertWords3(words[5])">${words[5]}</div>
     <div class="button" onclick="insertWords4(words[6])">${words[6]}</div>
     <div class="button" onclick="insertWords4(words[7])">${words[7]}</div>
     </div>`;
    document.getElementById('app').innerHTML = html;
};

//  Controller endrer modellen
function insertWords1(word) {
    word1 = word;
    sentence = "Once there was " + word1 + " " + word2 + " that " + word3 + " in the " + word4 + " - and great things happened. The End";
    document.getElementById('sentence').innerHTML = sentence;
    updateView();

}
function insertWords2(word) {
    word2 = word;
    sentence = "Once there was " + word1 + " " + word2 + " that " + word3 + " in the " + word4 + " - and great things happened. The End";
    document.getElementById('sentence').innerHTML = sentence;
    updateView();
}
function insertWords3(word) {
    word3 = word;
    sentence = "Once there was " + word1 + " " + word2 + " that " + word3 + " in the " + word4 + " - and great things happened. The End";
    document.getElementById('sentence').innerHTML = sentence;
    updateView();
}
function insertWords4(word) {
    word4 = word;
    sentence = "Once there was " + word1 + " " + word2 + " that " + word3 + " in the " + word4 + " - and great things happened. The End";
    document.getElementById('sentence').innerHTML = sentence;
    updateView();
} 