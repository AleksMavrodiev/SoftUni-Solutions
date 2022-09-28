function ticTacGame(coordinates) {
    let initialBoard = 
    [[false, false, false],
    [false, false, false],
    [false, false, false]];

    for (let i = 0; i < coordinates.length; i++) {
        let hasWon = false;
        let isFree = false;
        let marker = i % 2 == 0 ? 'X' : 'O';
        let [x, y] = coordinates[i].split(' ');
        if (initialBoard[x][y] !== false) {
            console.log("This place is already taken. Please choose another!");
            continue;
        }
        for (let row = 0; row < initialBoard.length; row++) {
            for (let col = 0; col < initialBoard[row].length; col++) {
                if (initialBoard[row][col] == false) {
                    isFree = true;
                }
            }
        }
        if (!isFree) {
            console.log("The game ended! Nobody wins :(");
            break;
        }
        for (let row = 0; row < initialBoard.length; row++) {
            if (initialBoard[row][0] === marker && initialBoard[row][1] === marker && initialBoard[row][2] === marker) {
                console.log(`Player ${marker} wins!`);
                hasWon = true
                break;
            }
            if (initialBoard[0][row] === marker && initialBoard[1][row] === marker && initialBoard[2][marker]) {
                console.log(`Player ${marker} wins!`);
                hasWon = true;
                break;
            }
        }
        if (initialBoard[0][0] === marker && initialBoard[1][1] === marker && initialBoard[2][2] === marker) {
            console.log(`Player ${marker} wins!`)
            hasWon = true;
            break;
        }
        if (initialBoard[0][2] === marker && initialBoard[1][1] === marker && initialBoard[2][0] === marker){
            console.log(`Player ${marker} wins!`)
            hasWon = true;
            break;
        }
        if(hasWon){
            break;
        }
        initialBoard[x][y] = marker;
    }

    initialBoard.forEach(x => console.log(x.join('\t')));
}

ticTacGame(["0 1",
"0 0",
"0 2", 
"2 0",
"1 0",
"1 1",
"1 2",
"2 2",
"2 1",
"0 0"]
);