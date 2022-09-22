function solve(numbers){
    let first = Number(numbers.shift());
    let last = Number(numbers.pop());
    let sum = first + last;
    console.log(sum);
}

solve(['20', '30', '40']);