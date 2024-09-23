const SCRIPTS = require('./scripts');

require('./scripts.js');

function filter(array, test){
    let passed = [];
    for (let element of array){
        if(test(element)) {
            passed.push(element);
        }
    }
    return passed
}
//console.log(filter(SCRIPTS, script => script.living));
function map(array, transform){
    let mapped = [];
    for (let element of array) {
        mapped.push(transform(element));
    }
    return mapped
}
let rtlScripts = SCRIPTS.filter(s => s.direction == "rtl");
console.log(map(rtlScripts, s => s.name));