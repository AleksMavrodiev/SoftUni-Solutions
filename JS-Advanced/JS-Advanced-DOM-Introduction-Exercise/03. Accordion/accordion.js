function toggle() {
    let foo = document.getElementById("extra");
    let buttonText = document.getElementsByClassName("button")[0].textContent;
    if(foo.style.display == '' || foo.style.display == 'none'){
        foo.style.display = 'block';
    }
    else{
        foo.style.display = 'none';
    }
    if(buttonText == "Less"){
        buttonText = "More"
    }
    else{
        buttonText = "Less";
    }
    document.getElementsByClassName("button")[0].textContent = buttonText;
}