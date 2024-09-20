let pikachuName = "Pikachu"

let pikachu = {
  name: "Pikachu",
  health: 45,
  image: "Images/pikachu.png",
  level: 8,
};

let bulbasaur = {
  name: "Bulbasaur",
  health: 70,
  image: "Images/bulbasaur.png",
  level: 12,
};

let oranguru = {
  name: "Oranguru",
  health: 170,
  image: "Images/oranguru.png",
  level: 45,
};

let drowzee = {
  name: "Drowzee",
  health: 90,
  image: "Images/drowzee.png",
  level: 33,
};

let bjarne = {
  name: "Bjarne",
  image: "Images/pokemonTrainerIdle.png",
  pokemon: [],
}
let possiblePokemon = [pikachu, bulbasaur, oranguru, drowzee];
let randomPokemon = null;

let app = document.getElementById("app");

updateView();

function updateView() {
  getRandomPokemon()
  // randomPokemon.level = Math.floor(Math.random() * 100)
  // randomPokemon.health = Math.floor(Math.random() * 100)
  // console.log(randomPokemon.level, randomPokemon.health);
  app.innerHTML = /*HTML*/ `
  <div class="container">
    <div class="opposingPokemon">
        <div>${randomPokemon.name}</div> 
        <div>lvl: ${randomPokemon.level}</div>
        <img src="${randomPokemon.image}">
    </div>
    
    <div class="bottomScreen">
        <div class="player">
            <img src="${bjarne.image}">
            <div>${bjarne.name}</div>
        </div>

        <div class="buttonContainer">
            <button onclick="catchPokemon()">Fang</button>    
            <button onclick="updateView()">Finn en annen</button>
            <button onclick="showPokemon()">Vis dine pokemon</button>       
        </div>

    </div>
  </div>
  `;
}

function caughtPokemonView() {
  app.innerHTML = /*HTML*/`
  <div class="caughtContainer">
    <h1>Du fanget ${bjarne.pokemon[bjarne.pokemon.length - 1].name}</h1>
    <div class="buttonContainer">
              <button onclick="updateView()">Finn en annen</button>
              <button onclick="showPokemon()">Vis dine pokemon</button>
          </div>
  </div>
  `;
}

function catchPokemon() {
  bjarne.pokemon.push(randomPokemon);
  caughtPokemonView();
}

function showPokemon() {
  app.style = null;
  app.innerHTML = '';

  for (i = 0; i < bjarne.pokemon.length; i++){
    app.innerHTML = /*HTML*/ `
    
      <div>${bjarne.pokemon[i].name}</div>
  `;
  }
  app.innerHTML += /*HTML*/`
  <div>
    <button onclick="updateView()">Finn en annen</button>
  </div>
  `;
}

function getRandomPokemon() {
  let randomNum = Math.floor(Math.random() * possiblePokemon.length);
  randomPokemon = possiblePokemon[randomNum];
}
