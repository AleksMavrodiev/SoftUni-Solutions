function cook(number, ...commands){
    const parser = {
        chop() {number /= 2;},
        dice() {number = Math.sqrt(number);},
        spice() {number++;},
        bake() {number *= 3;},
        fillet() { number *= 0.8}
    }
    for(let command of commands){
        parser[command]();
        console.log(number);
    }

}

cook('32', 'chop', 'chop', 'chop', 'chop', 'chop');