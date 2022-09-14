function largestNumber(firstNumber, secondNumber, thirdNumber){
    let largest;
    if(firstNumber >= secondNumber && firstNumber >= thirdNumber){
        largest = firstNumber
    }
    else if(secondNumber >= firstNumber && secondNumber >= thirdNumber){
        largest = secondNumber;
    }
    else if(thirdNumber >= firstNumber && firstNumber >= secondNumber){
        largest = thirdNumber
    }
    console.log(`The largest number is ${largest}.`)
}

largestNumber(5, -3, 16);