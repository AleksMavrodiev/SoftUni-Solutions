function calculator() {
    let selector1;
    let selector2;
    let resultSelector;
    let action= {
        init: function(firstSelector, secondSelector, resSelector){
            selector1 = document.querySelector(firstSelector);
            selector2 = document.querySelector(secondSelector);
            resultSelector = document.querySelector(resSelector);
        },
        add: function(){
            let firstNum = Number(selector1.value);
            let secondnum = Number(selector2.value);
            let sum = firstNum + secondnum;
            resultSelector.value = sum;
        },
        subtract: function(){
            let firstNum = Number(selector1.value);
            let secondnum = Number(selector2.value);
            let sum = firstNum - secondnum;
            resultSelector.value = sum;
        }
    }
    return action;
}

const calculate = calculator (); 
calculate.init ('#num1', '#num2', '#result'); 


