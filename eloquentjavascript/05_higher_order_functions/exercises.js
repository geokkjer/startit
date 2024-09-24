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
