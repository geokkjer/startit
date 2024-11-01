updateView();
function updateView() {
    header.innerHTML = '<h1 class="header">Lån en sykkel</h1>';
    main.innerHTML = /*html*/ `
    <div>Alle sykkler:</div>
    ${bikeList()}`;
    input.innerHTML = /*html*/ `
    <h1> Legg til en sykkel:</h1>
    ${addBikeview()}
    `;
}

function bikeList() {
    let bikeHtml = '';
    let bikes = model.data.bikes
    for (i = 0; i < model.data.bikes.length; i++) {
        bikeHtml += /*html*/ `
        <div class="list">
        <ul>
            <li>Merke: ${bikes[i].brand}</li>
            <li>Gir: ${bikes[i].gears}</li>
            <li>Beskrivelse: ${bikes[i].description}</li>
            <li>Tilgjengelig: ${bikes[i].isAvilable}</li>
            <li>Tilstand: ${bikes[i].state}</li>
        </ul>
        </div>`;
    }
    return bikeHtml;
}
function addBikeview() {
    let addBikeHtml = /*html*/ `
    <div>
        <label class="labels">Merke:</label>
        <input type="text" onchange="model.input.newBike.brand = this.value">
    </div>
    <div>
        <label class="labels">Gir:</label>
        <input type="number" onchange="model.input.newBike.gears = this.value">
    </div>
    <div>
    Er sykkelen tigjengelig<input type="checkbox" checked="checked" onclick="model.input.newBike.isAvailable = this.value">Ja</button>
    <input type="checkbox" checked="" onclick="model.input.newBike.isAvailable = this.value">Nei</button>
    </div>
    <div>
        <label class="labels">Beskrivelse:</label>
        <textarea onchange="model.input.newBike.comment = this.value"></textarea>
    </div>

    <button onclick="addBike()">Legg til sykkel</button>
    `;
    return addBikeHtml

}