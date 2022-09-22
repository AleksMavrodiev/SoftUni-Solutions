function solve(numbers){
    let result = '';
    for(let i = 0; i < numbers.length; i++){
        if(i % 2 == 0){
            result += numbers[i] + ' ';
        }
    }
    console.log(result.trim());
}

solve(['20', '30', '40', '50', '60']);