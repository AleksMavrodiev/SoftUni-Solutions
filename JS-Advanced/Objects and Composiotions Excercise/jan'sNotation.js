function solve(input){
    let res = [];
    let numArr = [];
    let operandArr = [];

    let operationEnum = {
        "+": (a, b) => a + b,
        "-": (a, b) => a - b,
        "/": (a, b) => a / b,
        "*": (a, b) => a * b,
    }



    for(let element of input){
        if(typeof(element) === "number"){
            numArr.push(element);
        }
        else{
            operandArr.push(element)
        }
    }

    if(operandArr.length < numArr.length - 1){
        console.log("Error: too many operands!");
        return;
    }
    else if(numArr.lenth === operandArr.length || numArr.length === 0){
        console.log("Error: not enough operands!");
    }

    for(let element of input){
        if(typeof(element) === "number"){
            res.push(element);
            continue;
        }
        let numA = res.pop();
        let numB = res.pop();
        let res = operationEnum[element](numB, numA);
        res.push(res);
    }
    console.log(res);
}

solve([3, 4, '+']);