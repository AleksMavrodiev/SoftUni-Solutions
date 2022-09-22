function findBiggest(matrix){
    let resut = Number.MIN_VALUE;
    for(let row of matrix){
        for(let i = 0; i < row.length; i++){
            if(row[i] > resut){
                resut = row[i];
            }
        }
    }
    return resut
}

findBiggest([[3, 5, 7, 12],
    [-1, 4, 33, 2],
    [8, 3, 0, 4]]
   );
