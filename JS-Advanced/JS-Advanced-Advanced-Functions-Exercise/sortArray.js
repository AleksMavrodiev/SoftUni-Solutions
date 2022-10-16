function sortingArr(numbers, command){
    let result = Array.from(numbers);
    if(command == 'asc'){
        result.sort((a, b) => a - b);
    }
    else{
        result.sort((a, b) => b - a);
    }
    return result;
}

console.log(sortingArr([14, 7, 17, 6, 8], 'desc'))