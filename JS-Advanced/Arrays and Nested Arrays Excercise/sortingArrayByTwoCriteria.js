function solve(array){
    array.sort().sort((a, b) => a.length - b.length);
    console.log(array.join('\n'));
}

solve(['Isacc', 
'Theodor', 
'Jack', 
'Harrison', 
'George']

);