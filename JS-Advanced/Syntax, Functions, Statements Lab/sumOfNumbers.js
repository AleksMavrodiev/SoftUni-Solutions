function sumNums(firstNumber, secondNumber){
    let num1 = Number(firstNumber);
    let num2 = Number(secondNumber);
    let result = 0;
    for(let i = num1; i <= num2; i++){
        result += i;
    }
    console.log(result);
}

sumNums('1', '5' )