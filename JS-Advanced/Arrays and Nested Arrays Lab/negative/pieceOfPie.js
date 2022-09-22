function solve(pies, startPie, endPie){
    let startPieIndex = pies.indexOf(startPie);
    let endPieIndex = pies.indexOf(endPie);
    let result = [];
    for(let i = startPieIndex; i <= endPieIndex; i++){
        result.push(pies[i]);
    }
    return result;
}

