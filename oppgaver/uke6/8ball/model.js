
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
<main>
    <div class="content">
	    	<a class="btn rgb-animate-hvr">8-ball</a>
		</div>
    <div class="content rgb-animate">			
        Ask Your question: <input type="text" onchange="question = this.value" /><br>
        <button onclick="pickRandomAnswer()">Submit</button>
    </div>
</main>
`;
var htmlAnswer = '';

var answerArray = [];
var randomAnswersArrary = [];
var randomAnswer;
var question;