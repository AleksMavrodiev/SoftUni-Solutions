function rotateArray(array, count){
    for(let i = 0; i < count; i++){
        let removeElement = array.pop();
        array.unshift(removeElement);
    }
    console.log(array.join(' '));
}

rotateArray(['1', 
'2', 
'3', 
'4'], 
2
);