function printElements(array, counter){
    let result = [];
    for(let i = 0; i < array.length; i+=counter){
        result.push(array[i]);
    }
    return result;
}