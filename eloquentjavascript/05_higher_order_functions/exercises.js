let arrays = [[1,2,3], [4,5],[6,7]];
let newArray = [];
let newArray2 = arrays.flat();

for (let key in arrays) newArray = newArray.concat(arrays[key]);
// arrays.forEach((v) => {
//     newArray.push(v);
//     newArray.concat(v);
// })
// function reduceArrays(){
//     for (array of arrays) {
//         console.log(array,count)

//     } 
// }
//reduceArrays();
console.log(newArray2);

function loop(value, testFunc, updateFunc, bodyFunc){
    for (let i = 0; i < value; i++){
        if (testFunc == false){
            return 
        } else {
            // updateFunc(value)
            
            bodyFunc(value);
        }
        value--;
    }
    
}
loop(3, n => n > 0, n => n - 1, console.log);