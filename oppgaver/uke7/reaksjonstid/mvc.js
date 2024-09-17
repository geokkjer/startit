// model
var app = document.getElementById('app');
var html = ' ';
var lampArray = [];
var lightOn;

// view
updateView();
twentyFive();
lightUpRandomLamp();
function updateView() {
    app.innerHTML = html + `<button onclick="lightUpRandomLamp()">Light up random lamp</button>`;
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
    let selectedLampIndex = Math.floor(Math.random() * lampArray.length);
    divToReplace = document.getElementById(selectedLampIndex);
    let divToreplaceWith = document.getElementById(selectedLampIndex).classList = `circles  lightOn`
    html = html.replace(divToReplace, divToreplaceWith);
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
