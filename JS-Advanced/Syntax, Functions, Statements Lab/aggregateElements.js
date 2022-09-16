function aggregateElements(input){
    let array = input;
    let sum = 0;
    let inverseSum = 0;
    let concat = '';
    for(let i = 0; i < array.length; i++){
        sum += array[i];
        inverseSum += 1/array[i]
        concat += array[i];
    }
    console.log(sum);
    console.log(inverseSum);
    console.log(concat);
}

aggregateElements([1, 2, 3]);