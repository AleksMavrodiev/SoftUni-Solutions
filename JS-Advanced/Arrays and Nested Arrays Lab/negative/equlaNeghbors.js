function solve(inputArr) {
    let matchesCount = 0;

    for (let row = 0; row < inputArr.length; row++) {
        for (let col = 0; col < inputArr[row].length; col++) {
            let currVariable = inputArr[row][col];
           
            if (row < inputArr.length - 1) {
                
                let downNeighborVariable = inputArr[row + 1][col];
                

                if (currVariable === downNeighborVariable) {
                    matchesCount++;
                }
            }

            if(col < inputArr[row].length - 1){
                
                let rightNeighborVariable = inputArr[row][col + 1];

                if(currVariable === rightNeighborVariable){
                    matchesCount++;
                }
            }
        }
    }

    return matchesCount;
}



console.log(solve([['2', '3', '4', '7', '0'],
['4', '0', '5', '3', '4'],
['2', '3', '5', '4', '2'],
['9', '8', '7', '5', '4']]
));