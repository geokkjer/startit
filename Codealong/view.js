updateView();
function updateView() {
    app.innerHTML = /*html*/ `
    <h1>Bikes R Us</h1>
    <div>Alle sykkler:</div>
    ${bikeList()}

    `;
}
function bikeList() {
    let bikeHtml = '';

    for (i = 0; i < modell.data.bikes.length; i++) {
        bikeHtml += /*html*/ `
        
        <ul>
            <li>Merke: ${modell.data.bikes[i].modell}</li>
            <li>Gir: ${modell.data.bikes[i].gears}</li>
            <li>Beskrivelse: ${modell.data.bikes[i].description}</li>
            <li>Tilgjengelig: ${modell.data.bikes[i].isAvilable}</li>
            <li>Tilstand: ${modell.data.bikes[i].state}</li>
        </ul>`;
    }
    return bikeHtml;
}
function addBikeview(){
    let addBikeHtml = /*html*/ `
        
    `;

}