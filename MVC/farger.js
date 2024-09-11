// model

let colors = ['red', 'green', 'blue', 'yellow', 'grey']
let isAdding = false;
let addColorName;


// view
updateView();
function updateView() {
    document.getElementById('app').innerHTML = /*HTML*/`
            ${createAddColorHtml()}
            <div class="colors">
                ${createColorsHtml()}
            </div>
        `;
}
function createAddColorHtml() {
    if (!isAdding) return '<button onclick="startAdd()">+</button>';
    return /*HTML*/ `
        <input
            type="text"
            oninput="addColorName=this.value"
            value="${addColorName ?? ''}"
            />
        <button onclick="addColor()">Legg til ny farge</button>
        <button onclick="cancelAddColor()">Avbryt</button>
    `;

}
function addColor() {
    colors.push(addColorName);
    isAdding = false;
    addColorName = '';
    updateView();
}
function createColorsHtml() {
    let colorsHtml = '';
    for (let i = 0; i < colors.length; i++) {
        let color = colors[i];
        colorsHtml += /*HTML*/ `
            <div class="color">
                <div class="topBox">
                    <div>${color}</div>
                    <button onclick="deleteColor(${i})">x</button>
                    </div>
                    <div style="background-color: ${color}" class="box"></div>
            </div>
        `;
    }
    return colorsHtml;
}
// Controller
function addColor(){
    colors.push(addColorName);
    isAdding = false;
    addColorName = '';
    updateView();
}
function deleteColor(index) {
    colors.splice(index, 1)
    updateView();
}
function startAdd() {
    isAdding = true;
    updateView();

}
function cancelAdd() {
    isAdding = false;
    updateView();
}