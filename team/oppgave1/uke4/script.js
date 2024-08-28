// Model
let lifeTimer = 100;
let foodTime = 10;
let petTime = 10;
let foodElement = document.getElementById("foodId");
let petElement = document.getElementById('petId');
let frogImage = document.getElementById('tamaFrog').src = "img/default.jpg";


setInterval(foodFunction, 1000)

// View
function foodFunction() {

    if (foodTime < 0) {
        //game over???
        document.getElementById('tamaFrog').src = "img/dead.jpg";
        document.getElementById('tamaFrog').style.backgroundColor = 'red';
        setInterval(afterLife, 1000);
    } else {
        foodElement.innerHTML = foodTime + " seconds remaining"
        foodTime--
        if (foodTime < 5) {
            document.getElementById('tamaFrog').src = "img/need_food.jpg";
        }
    }
}
// Controller
function feed() {
    if (foodTime > 0) {
        foodTime += 10;
        document.getElementById('tamaFrog').src = "img/eating.jpg";
        setTimeout(defaultImg, 500)

    }

}

function defaultImg() {
    document.getElementById('tamaFrog').src = "img/default.jpg";
}

function petFunction() {
    if (petTime < 0) {

        document.getElementById('petFrog').src = "img/need_petting.jpg";
    } else {
        petElement.innerHTML = petTime + "seconds remaining"
        foodTime--
        if (petTime < 3) {
            document.getElementById('petFrog').src = "img/need_love.jpg";
        }
    }
}
function pet() {
    if (petTime > 0) {
        petTime += 10;
        document.getElementById('petFrog').src = "img/need_love.jpg";
        setTimeout(defaultImg, 500)

    }

}
function defaultImg() {
    document.getElementById('tamaFrog').src = "img/default.jpg";
}
function afterLife() {
    document.getElementById('tamaFrog').src = "img/ghost.jpg";
}