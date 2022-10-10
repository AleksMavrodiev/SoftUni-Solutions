function attachEventsListeners() {
    let buttons = Array.from(document.querySelectorAll("input[type=button]"));
    for(let button of buttons){
        button.addEventListener('click', calculate);
    }

    function calculate(event){
        let buttonId = event.target.id;
        let buttonValue = Number(event.target.parentElement.children[1].value);
        switch(buttonId){
            case "daysBtn":
                fillFields(buttonValue);
                break;
            case "hoursBtn":
                fillFields(buttonValue / 24);
                break;
            case "minutesBtn":
                fillFields(buttonValue / 24 / 60);
                break;
            case "secondsBtn":
                fillFields(buttonValue / 24 / 60/ 60);
                break;
        }


        function fillFields(days){
            let textFields = Array.from(document.querySelectorAll("input[type=text]"));
            for(let i = 0; i < textFields.length; i++){
                switch(i){
                    case 0:
                        textFields[i].value = days;
                        break;
                    case 1:
                        textFields[i].value = days * 24;
                        break;
                    case 2:
                        textFields[i].value = days * 24 * 60;
                        break;
                    case 3:
                        textFields[i].value = days * 24 * 60 * 60;
                        break;
                }
            }
        }
    }
}