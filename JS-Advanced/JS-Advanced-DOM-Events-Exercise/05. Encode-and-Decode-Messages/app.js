function encodeAndDecodeMessages() {
    let encodeButton = document.querySelectorAll("button")[0].addEventListener('click', encodeText);
    let decodeButton = document.querySelectorAll("button")[1].addEventListener('click', decodeText);

    function encodeText(){
        let textArea = document.querySelectorAll("textarea")[0].value;
        let newMsg = "";
        for(let i = 0; i < textArea.length; i++){
            let currentCh = textArea[i].charCodeAt();
            newMsg += String.fromCharCode(currentCh + 1);
        }

        let inputArea = document.querySelectorAll("textarea")[0];
        let resultArea = document.querySelectorAll("textarea")[1];
        resultArea.value = newMsg;
        inputArea.value = "";
    }

    function decodeText(){
        let resultAreaText = document.querySelectorAll("textarea")[1].value;
        let newMsg = "";
        for(let i = 0; i < resultAreaText.length; i++){
            let currentCh = resultAreaText[i].charCodeAt();
            newMsg += String.fromCharCode(currentCh - 1);
        }
        let resultArea = document.querySelectorAll("textarea")[1];
        resultArea.value = newMsg;
    }
}