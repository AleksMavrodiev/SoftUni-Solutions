function cook(number, ...actions){
    for(let i = 0; i < actions.length; i++){
        if(actions[i] == "chop"){
            number /= 2;
        }
        else if(actions[i] == "dice"){
            number = Math.sqrt(number);
        }
        else if(actions[i] == "spice"){
            number++;
        }
        else if(actions[i] == "bake"){
            number *= 3;
        }
        else if(actions[i] == "fillet"){
            number *= 0.8;
        }
        console.log(number);
    }
}

cook('9', 'dice', 'spice', 'chop', 'bake', 'fillet');