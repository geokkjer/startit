let empty = {};
console.log(Object.getPrototypeOf({}) == Object.prototype);
console.log(Object.getPrototypeOf(Object.prototype));

console.log(Object.getPrototypeOf(Math.max) == Function.prototype);

let protoRabbit = {
    speak(line) {
        console.log(`The ${this.type} rabbit says '${line}`)
    }
};

let blackRabbit = Object.create(protoRabbit);
blackRabbit.type = "black";
blackRabbit.speak("I am fear and darkness");

function makeRabbit(type){
    let rabbit = Object.create(protoRabbit);
    rabbit.type = type;
    return rabbit;
}
class Rabbit {
    constructor(type) {
        this.type = type;
    }
    speak(line){
        console.log(`The ${this.type} rabbit says '${line}`)
    }
}

let killerRabbit = new Rabbit("killer");
const materials = ['Hydrogen', 'Helium', 'Lithium', 'Beryllium']
console.log(materials.map((material) => material.includes('Helium')));
let addABPlussHundred = (a,b) => a + b + 100;
console.log(addABPlussHundred(10,19))

const greetings = name => {
    console.log(`Hello, ${name}!`);
}
greetings('Geir');

const myFunction = (param1,param2)  => {

}