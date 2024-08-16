blankAll()
function blankAll() {
    document.getElementById('green').innerHTML = '';
    document.getElementById('blue').innerHTML = '';
    document.getElementById('red').innerHTML = '';
    document.getElementById('yellow').innerHTML = '';

}
function green() {
    blankAll();
    document.getElementById('green').innerHTML = /*HTML*/ `
    De to viktigste verktøyene vi skal bruke er disse:
    <ul>
        <li>
            Koderedigeringsprogrammet <a href="https://code.visualstudio.com/">Visual Studio Code</a>
            <br>
            Vi skal bruke noen <i>extensions</i>:
            <ul>
                <li>JavaScript-booster</li>
                <li>es6-string-html</li>
                <li>live-server</li>
                <li>live-share</li>
            </ul>
        </li>
        <li>Nettleseren <a href="https://www.google.com/intl/no/chrome/">Chrome</a></li>
    </ul>`;
}
function blue() {
    blankAll();
    document.getElementById('blue').innerHTML = /*HTML*/ `
    Vi bruker HTML til å definere et dokument.
            <ul>
                <li>Tagger for grunnleggende oppsett av en HTML-fil</li>
                <li>Tagger for grunnleggende formatering av tekst</li>
                <li><tt>&lt;div&gt;</tt></li>
                <li><tt>&lt;input type="text"&gt;</tt></li>
                <li><tt>&lt;button&gt;</tt></li>
                <li><a href="https://www.w3schools.com/html/default.asp" target="_new">W3Schools HTML Tutorial</a>
                </li>
                <li><a href="https://www.w3schools.com/tags/default.asp" target="_new">W3Schools HTML Reference</a>
                </li>
            </ul>
            `;
}
function red() {
    blankAll();
    document.getElementById('red').innerHTML = /*HTML*/ `
    Vi bruker CSS til å <i>style</i> et dokument, altså farger, fonter, utseende og lignende.
    <ul>
        <li><tt>background-color</tt></li>
        <li><tt>color</tt></li>
        <li><tt>padding</tt></li>
        <li><tt>margin</tt></li>
        <li><tt>border</tt></li>
        <li><tt>text-align</tt></li>
        <li><tt>font-size</tt></li>
        <li><a href="https://css-tricks.com/snippets/css/a-guide-to-flexbox/" target="_new">Flexbox</a></li>
        <li><a href="https://css-tricks.com/snippets/css/complete-guide-grid/" target="_new">Grid</a></li>
        <li><a href="https://www.w3schools.com/css/default.asp" target="_new">W3Schools CSS Tutorial</a>
        </li>
        <li><a href="https://www.w3schools.com/cssref/default.asp" target="_new">W3Schools CSS Reference</a>
        </li>
    </ul>
    `;
}
function yellow() {
    blankAll();
    document.getElementById('yellow').innerHTML = /*HTML*/ `
    Det viktigste vi skal lære er programmeringsspråket JavaScript. Vi skal lære grunnleggende programmering
    ved
    å manipulere HTML- og CSS-kode på en nettside ved hjelp av JavaScript.
    <ul>
        <li>Det finnes en W3Schools JavaScript Tutorial, men her anbefaler vi heller å følge kurset vårt på
            Moodle.</li>
        <li><a href="https://www.w3schools.com/jsref/default.asp" target="_new">W3Schools JavaScript
                Reference</a></li>
    </ul>`;
}
function dark() {
    document.getElementById('dark').innerHTML = /*HTML*/ `
    <div id="head" class="bodyPart">
                <button onclick="selectHead4()">◀</button>
                <img src="img/head1.png">
                <button onclick="selectHead2()">▶</button>
            </div>
        `;
}
function selectHead(){


}