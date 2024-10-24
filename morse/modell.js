const app = document.getElementById('app')

const morseCodeArray = [ '.-', '-...', '-.-.', '-..', '.', '..-.', '--.', '....', '..', '.---', '-.-', '.-..', '--', '-.', '---', '.--.', '--.-', '.-.', '...', '-', '..-', '...-', '.--', '-..-', '-.--', '--..', ' ', '·−·−', '−−−·', '·−−·−'];
//                         1      2      3       4     5      6     7       8       9      10     11      12     13    14    15      16      17     18     19    20    21     22      23     24      25      26     27     28      29       30
//                         A      B      C       D     E      F     G       H       I      J      K       L      M     N     O       P       Q      R      S     T     U      V       W      X       Y       Z            Æ       Ø        Å
const alphabetArray = "abcdefghijklmnopqrstuvwxyz æøå";

let lettersFromInput = " ";
let letterTranslatedToMorse = " ";