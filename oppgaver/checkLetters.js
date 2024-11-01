const letters = "abcdefghijklmnopqrstuvwxzy ";
let string = "Not a pangram";
let string2 = "The quick brown fox jumps over the lazy dog"

// console.log(letters, string,letterArray, stringArray,test)



function isPangram(str) {
    const lowerStr = str.toLowerCase();

    if (letters.split('').every(char => lowerStr.includes(char))){
        console.log('ja')
        return true;

    } else {
        console.log('nei')
        return false
    };
}

isPangram(string2);