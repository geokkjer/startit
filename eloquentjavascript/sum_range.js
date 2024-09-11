var numArray = [];
function range(start, stop) {
    for (start; start <= stop; start++) {
        numArray.push(start)
    }
    return numArray;
}
function sum(numArray) {
    let sumArray = 0;
    for (i = 0; i < numArray.length; i++){
        sumArray = sumArray + numArray[i]
    }
    return sumArray;
}



console.log(sum(range(1, 10)));