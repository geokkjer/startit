let todoList = [];

function remember(task) {
    todoList.push(task)
}
function getTask() {
    return todoList.shift();
}
function rememberUrgently(task) {
    todoList.unshift(task)
}

// remember("groceries");
// remember("sleep");
// console.log(todoList);
// console.log(getTask());
// rememberUrgently("eat");
// remember("run");
// console.log(todoList);
// console.log(todoList.indexOf(2));

function remove(array, index) {
    return array.slice(0, index)
        .concat(array.slice(index + 1));
}
// console.log(remove(["a", "b", "c", "d", "e"], 2));

let sentence = "Secretarybirds specialize in stomping";
let words = sentence.split(" ");
// console.log(words);
// console.log(words.join(". "));

function max(...numbers) {
    let result = -Infinity;
    for (let number of numbers) {
        if (number > result) result = number;
    }
    return result;
}
let numbers = [4, 1, 9, -22, 14, 69, 1337];
console.log(max(...numbers));

function randomPointOnCircle(radius) {
    let angle = Math.random() * 2 * Math.PI;
    return {
        x: radius * Math.cos(angle),
        y: radius * Math.sin(angle)
    };
}
console.log(randomPointOnCircle(2));
