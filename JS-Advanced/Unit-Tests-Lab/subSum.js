function sumArr(array, startIndex, endIndex){
    let sum = 0;

    if(!Array.isArray(array)){
        return NaN;
    }
    if(startIndex < 0){
        startIndex = 0;
    }
    if(endIndex >= array.length){
        endIndex = array.length - 1;
    }
    for(let i = startIndex; i <= endIndex; i++){
        sum += Number(array[i]);
    }

    return sum; 
}

console.log(sumArr([10, 20, 30, 40, 50, 60], 3, 300))