

// model
var app = document.getElementById('app');
var html = ' ';
var lampArray = [];
var selectedLampIndex = 0;
var lightOn;
var clickLamp = document.getElementById('selectedLampIndex')
var startTime = new Date().getTime();
var finishTime = new Date().getTime();
var spentMilliseconds = Math.floor(finishTime - startTime);
var spentSeconds = spentMilliseconds / 1000;

// view
updateView();
twentyFive();
lightUpRandomLamp();
function updateView() {
    app.innerHTML = html + /*HTML*/` <h2>Klikk på en lampe for å skifte</h2><div id="showTime">timeSpent</div>`;
}

// controller
function twentyFive() {
    lampArray = [];
    let lamp = 0;
    for (i = 0; i < 25; i++) {
        html += /*HTML*/ `
        <div class="circles" id="${lamp}"></div>
        `;
        lampArray.push(lamp)
        lamp++;
    }
    updateView();

}

function lightUpRandomLamp() {
    checkForLightOn();
    let divToReplace = ' ';
    selectedLampIndex = Math.floor(Math.random() * lampArray.length);
    divToReplace = document.getElementById(selectedLampIndex);
    let divToreplaceWith = document.getElementById(selectedLampIndex).classList = `circles  lightOn`
    html = html.replace(divToReplace, divToreplaceWith)
    setOnClick = document.getElementById(selectedLampIndex).onclick = lightUpRandomLamp;
    startTimer();
    html = html + setOnClick

    clearScreen();
    

}
function clearScreen() {
    html = '';
}
function checkForLightOn() {
    for (i = 0; i < lampArray.length; i++) {
        document.getElementById(i).classList.contains('circles')
        if (document.getElementById(i).classList.contains("lightOn")) {
            document.getElementById(i).classList = `circles`;
        }
    }
}
function startTimer() {
    clickLamp.addEventListener("click", stopTimer)
    var currentTime = new Date().getTime();
    let timeSpent = Math.floor(currentTime - startTime)
    let timeSpentSeconds = (timeSpent / 1000)

    console.log(timeSpentSeconds)
}

function stopTimer() {
    document.getElementById(selectedLampIndex).removeEventListener("click", stopTimer)

    var currentTime = new Date().getTime();
    let timeSpent2 = Math.floor(currentTime - startTime)
    newTime = (timeSpent2 / 1000)
    console.log(newTime);
    document.getElementById(selectedLampIndex).addEventListener("click", startTimer)
}
