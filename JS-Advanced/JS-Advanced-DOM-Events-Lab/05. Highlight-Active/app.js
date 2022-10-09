function focused() {
    let sections = Array.from(document.querySelectorAll('input'));
    for(let section of sections){
        section.addEventListener('focus', onFocus);
        section.addEventListener('blur', outOfFocus);
    }

    function onFocus(event){
        event.target.parentNode.classList.add("focused");
    }

    function outOfFocus(event){
        event.target.parentNode.classList.remove("focused");
    }
}