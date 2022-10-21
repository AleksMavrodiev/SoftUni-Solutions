function solve(input){
    let juiceQuantity = {};
    let bottles = {};
    for(let data of input){
        let[juice, quantity] = data.split(" => ");
        quantity = Number(quantity);
        if(juiceQuantity.hasOwnProperty(juice)){
            juiceQuantity[juice] += quantity;
        }
        else{
            juiceQuantity[juice] = quantity;
        }

        let bottlesCount = Math.trunc(juiceQuantity[juice] / 1000);
        if(bottlesCount > 0){
            juiceQuantity[juice] -= bottlesCount * 1000;
            if(bottles.hasOwnProperty(juice)){
                bottles[juice] += bottlesCount;
            }
            else{
                bottles[juice] = bottlesCount;
            }
        }
    }

    for(let [key, value] of Object.entries(bottles)){
        console.log(`${key} => ${value}`);
    }
}


solve(['Kiwi => 234',
'Pear => 2345',
'Watermelon => 3456',
'Kiwi => 4567',
'Pear => 5678',
'Watermelon => 6789']
);