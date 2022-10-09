function validate() {
    let field = document.getElementById("email");
    field.addEventListener('change', validation);

    function validation(event){
        let fieldText = document.getElementById("email").value;
        const regEx = new RegExp(/[a-z]+[@][a-z]+[\.][a-z]+/);
        
        if(regEx.test(fieldText)){
            event.target.classList.remove("error");
        }
        else{
            event.target.classList.add("error");
        }
    }
}