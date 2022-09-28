function solve(arr){
    let result = arr.reduce((acc, currNum) => {if(acc.length !== 0){if(acc[acc.length - 1] <= currNum){acc.push(currNum);}}else{acc.push(currNum);}return acc; }, []);
    return result;
}