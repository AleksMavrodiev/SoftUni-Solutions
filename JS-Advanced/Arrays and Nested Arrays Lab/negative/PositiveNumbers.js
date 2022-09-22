function solve(numbers){
    let result = [];
    for(let i = 0; i < numbers.length; i++){
        if(numbers[i] >= 0){
            result.push(numbers[i]);
        }
        else{
            result.unshift(numbers[i]);
        }
    }
    for(let number of result){
        console.log(number);
    }
}

solve([7, -2, 8, 9]);