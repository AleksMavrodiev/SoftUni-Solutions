function magicMatrix(matrix){
    let isMagic = true;
    let rowSumBase = matrix[0].reduce((accumulator, currValue) => accumulator + currValue);
    for(let row = 0; row < matrix.length; row++){
        let rowSum = 0;
        for(let col = 0; col < matrix[row].length; col++){
            rowSum += matrix[row][col];
        }
        if(rowSum !== rowSumBase){
            isMagic = false;
            break;
        }
    }
    for(let col = 0; col < matrix.length; col++){
        let colSum = 0;
        for(let row = 0; row < matrix.length; row++){
            colSum += matrix[row][col];
        }
        if(colSum !== rowSumBase){
            isMagic = false;
            break;
        }
    }
    console.log(isMagic);
}

magicMatrix([[1, 0, 0],
    [0, 0, 1],
    [0, 1, 0]]
   );