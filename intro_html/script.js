blankAll()
function blankAll(){
    document.getElementById('inner').innerHTML = '';
}
function green() {
    blankAll();
    document.getElementById('inner').innerHTML = /*HTML*/ `
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

}
function red() {
    
}