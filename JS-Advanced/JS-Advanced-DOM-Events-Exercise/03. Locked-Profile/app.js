function lockedProfile() {
    let buttons = Array.from(document.querySelectorAll("button"));
    for(let button of buttons){
        button.addEventListener('click', showMore)
    }

    function showMore(event){
        let radioButtons = Array.from(event.target.parentElement.querySelectorAll("input[type=radio]"));
        let hiddentContents = event.target.parentElement.querySelectorAll("div")[0];
        if(!radioButtons[0].checked && event.target.innerText == "Show more"){
            event.target.textContent = "Hide it";
            hiddentContents.style.display = 'block';
        }
        else if(!radioButtons[0].checked && event.target.innerText == "Hide it"){
            event.target.textContent = "Show more";
            hiddentContents.style.display = 'none';
        }
        else{
            return;
        }
    }
}