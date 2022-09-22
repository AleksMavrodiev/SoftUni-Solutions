function solve(a, b){
    let n = Number(a);
    let k = Number(b);
    let numbers = [1];
    for(let i = 1; i < n; i++){
        let previousSum = 0;
        for(let j = i - 1; j >= i - k; j--){
            if(j >= 0 ){
                previousSum += numbers[j];
            }
        }
        numbers[i] = previousSum;
    }
    return numbers;
}

solve(8, 2);