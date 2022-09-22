function check(x1, y1, x2, y2){
    let chechFirstNull = Math.sqrt(Math.pow(0 - x1, 2) + Math.pow(0 - y1, 2));
    let isFirstValid = Number.isInteger(chechFirstNull);
    let chechsecondNull = Math.sqrt(Math.pow(0 - x2, 2) + Math.pow(0 - y2, 2));
    let isSecondValid = Number.isInteger(chechsecondNull);
    let checkBoth = Math.sqrt(Math.pow(x2 - x1, 2) + Math.pow(y2 - y1, 2));
    let areBothValid = Number.isInteger(checkBoth);
    console.log(`{${x1}, ${y1}} to {0, 0} is ${isFirstValid ? "valid" : "invalid"}`);
    console.log(`{${x2}, ${y2}} to {0, 0} is ${isSecondValid ? "valid" : "invalid"}`);
    console.log(`{${x1}, ${y1}} to {${x2}, ${y2}} is ${areBothValid ? "valid" : "invalid"}`);
}

check(2, 1, 1, 1);