function solution(){
    let storage = {
        protein: 0,
        carbohydrate: 0,
        fat: 0,
        flavour: 0
    }

    let recipesEnum = {
        apple: {carbohydrate: 1, flavour: 2},
        lemonade: {carbohydrate: 10, flavour: 20},
        burger: {carbohydrate: 5, fat: 7, flavour: 3},
        eggs: {protein: 5, fat: 1, flavour: 1},
        turkey: {protein: 10, carbohydrate: 10, fat: 10, flavour: 10}
    };

    return function(input){
        let [command, microelement, quantity] = input.split(" ");
        quantity = Number(quantity);
        let functions =  handleInput(microelement, quantity);
        return functions[command]();
    }

    function handleInput(microelement, quantity){
        return {
            restock: function(){
                storage[microelement] += quantity;
                return "Success";
            },
            prepare: function(){
                let storageCopy = JSON.parse(JSON.stringify(storage));
                let isDone = true;
                for(let [ingredient, value] of Object.entries(recipesEnum[microelement])){
                    if(storageCopy[ingredient] < value * quantity){
                        isDone = false;
                    }
                    else{
                        storageCopy[ingredient] -= value * quantity;
                    }
                    if(isDone == false){
                        return `Error: not enough ${ingredient} in stock`;
                    }
                }
                if(isDone){
                    storage = storageCopy;
                    return "Success";
                }
            },
            report: function(){
                return `protein=${storage.protein} carbohydrate=${storage.carbohydrate} fat=${storage.fat} flavour=${storage.flavour}`;
            },
        }
    }
}

let manager = solution (); 
console.log (manager ('prepare turkey 1')); // 'Error: not enough protein in stock'
console.log (manager ('restock protein 10')); // Success
console.log (manager ('prepare turkey 1')); // Error: not enough carbohydrate in stock 
console.log (manager ('restock carbohydrate 10')); // Success
console.log (manager ('prepare turkey 1')); //'Error: not enough fat in stock'
console.log (manager ("prepare lemonade 4")); // Error: not enough carbohydrate in stock 
console.log (manager ("prepare lemonade 4")); // Error: not enough carbohydrate in stock 
console.log (manager ("prepare lemonade 4")); // Error: not enough carbohydrate in stock 
console.log (manager ("prepare lemonade 4")); // Error: not enough carbohydrate in stock 
console.log (manager ("prepare lemonade 4")); // Error: not enough carbohydrate in stock 
console.log (manager ("prepare lemonade 4")); // Error: not enough carbohydrate in stock 
console.log (manager ("prepare lemonade 4")); // Error: not enough carbohydrate in stock 
