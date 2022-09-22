function solve(numbers){
    numbers.sort((a, b) => a - b);
    const middle = Math.floor(numbers.length / 2);
    const result = numbers.slice(middle);

    return result;
}

solve([4, 7, 2, 5]);