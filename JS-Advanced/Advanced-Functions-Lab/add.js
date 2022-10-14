function solution(number){
    let param = number;
    return function(adding){
        return param + adding;
    }
}

let add5 = solution(5);
console.log(add5(2));
console.log(add5(3));
