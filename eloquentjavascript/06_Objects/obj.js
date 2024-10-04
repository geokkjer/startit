function speak(line){
    console.log(`The ${this.type} rabbit says '${line}'`)
}

let whiteRabbit = {
    type: "white", speak
};

let hungryRabbit = {
    type: "hungry", speak
};
whiteRabbit.speak("Oh my fur and whiskers");

hungryRabbit.speak("Got any carrots?");

let finder = {
    find(array){
        return array.some(v => v == this.value)
    },
    value: 5
};
console.log(finder.find([4, 5]))
const array = [1, 2, 3, 4, 5];

// Checks whether an element is even
const even = (element) => element % 2 === 0;

console.log(array.some(even));

let empty = {
    name: "Geir",
    age: 51,
};
console.log(empty.age.toLocaleString(), ++empty.age);