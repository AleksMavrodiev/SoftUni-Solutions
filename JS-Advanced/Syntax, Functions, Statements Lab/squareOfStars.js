function printSquare(count){
    for(let i = 0; i < count; i++){
        let line = '';
        for(let j = 0; j < count; j++){
            line += '* ';
        }
        console.log(line)
    }
}

printSquare(5);
printSquare(1);