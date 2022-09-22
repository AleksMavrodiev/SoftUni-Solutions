function sameNumbers(number){
    let sum = 0;
    let isSame = true;
    let initialValue = number % 10;
    while(number != 0){
        let digit = number % 10;
        sum += digit;
        number = Math.floor(number / 10);
        if(digit != initialValue){
            isSame = false;
            
        }
       
    }
    console.log(isSame);
    console.log(sum);
}

//sameNumbers(2222222);
sameNumbers(1);