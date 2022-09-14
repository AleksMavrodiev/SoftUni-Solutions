function stringAverage(firstWord, secondWord, thirdWord){
    let firstCount = firstWord.length;
    let secondCount = secondWord.length;
    let thirdCount = thirdWord.length;
    let sumLength = firstCount + secondCount + thirdCount;
    let averageLength = Math.floor(sumLength / 3);
    console.log(sumLength);
    console.log(averageLength);
}

stringAverage('chocolate', 'ice cream', 'cake');