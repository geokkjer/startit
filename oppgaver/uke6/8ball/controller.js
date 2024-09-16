function pickRandomAnswer(){
    answerArray = [AffirmativeAnswers, nonCommittalAnswers, negativeAnswers];
   
    randomAnswersArrary = answerArray[Math.floor(Math.random() * answerArray.length)]; 
    
    randomAnswer = randomAnswersArrary[Math.floor(Math.random() * randomAnswersArrary.length)]
    htmlAnswer = /*HTML*/ `
        <div>Your question: ${question}, does not matter</div><br>
        <div>Answer: ${randomAnswer}</div>
    `;
    clearScreen();
    updateView();
}

function clearScreen(){
    app.innerHTML = '';
}