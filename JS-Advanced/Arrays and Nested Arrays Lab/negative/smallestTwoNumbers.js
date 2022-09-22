function solve(numbers){
    let smallestNumber = Number.MAX_VALUE;
    let secondSmallest = 0;
    for(let i = 0; i < numbers.length; i++){
        if(numbers[i] <= smallestNumber){
            secondSmallest = smallestNumber;
            smallestNumber = numbers[i];
        }
    }
    console.log(`${smallestNumber} ${secondSmallest}`);
}

solve([30, 15, 50, 5]);