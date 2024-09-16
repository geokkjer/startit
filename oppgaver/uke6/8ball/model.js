
var app = document.getElementById('app')
const AffirmativeAnswers = [
    'It is certain', 'It is decidedly so',
    'Without a doubt', 'Yes definitely',
    'You may rely on it', 'As I see it, yes',
    'Most likely', 'Outlook good',
    'Yes', 'Signs point to yes'
];
const nonCommittalAnswers = [
    'Reply hazy, try again', 'Ask again later',
    'Better not tell you now', 'Cannot predict now',
    'Concentrate and ask again'
];
const negativeAnswers = [
    'Don\’t count on it', 'My reply is no',
    'My sources say no', 'Outlook not so good',
    'Very doubtful'
];
var html = /*HTML*/`
    <div id="ball">8-ball</div>
    Ask Your question: <input type="text" /><br>
    <button onclick="pickRandomAnswer()">Submit</button>
`;
var htmlAnswer = '';

var answerArray = [];
var randomAnswersArrary = [];
var randomAnswer;