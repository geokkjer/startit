let total = 0, count = 1;
while (count < 10) {
    total += count;
    count += 1;
}

// for (let i = 0; i < 10; i++){
//     console.log(i)
// }

function repeatLog(n){
    for (let i = 0; i < n; i++){
        console.log(i)
    }
}


function repeat(n, action){
    for (let i = 0; i < n; i++){
        action(i);
    }
}

let labels = [];
repeat(5, i => {
    labels.push(`Unit ${i + 1}`);
})
console.log(labels);

function greaterThan(n){
    return m => m > n;
}
let greaterThan10 = greaterThan(10);
console.log(greaterThan10(9));

function noisy(f) {
    return (...args) => {
        console.log("calling with", args);
        let result = f(...args);
        console.log("called with", args, ", returned", result);
        return result;
    };
}
noisy(Math.max)(3, 2, 1);

function unless(test, then){
    if(!test)then();
}
repeat(13, n => {
    unless(n % 2 == 1, () => {
        console.log(n, "is even");
    });
});
["A", "B"].forEach(l => console.log(l));

// Hashrocket - Arrow functions
const square = x => x * x;
console.log(square(4))
const sum = (a,b) => {
    return a + b
}
console.log(sum(2,4));

function outerFunction(){
    var outerVariable = "Hello, ";

    function innerFunction(name){
        var innerVariable = "World!";
        var message = () => {
            console.log(outerVariable + name + " " + innerVariable);
        };
        return message()
    }
    innerFunction("John");
}
outerFunction();

const numbers = [1,2,3,4,5];
const filteredNumbers = numbers.filter(number => number % 2 === 0);