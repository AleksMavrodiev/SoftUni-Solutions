function solve(input){
    let result = [];
    for(let i = 1; i < input.length; i++){
        let town = {};
        let [townName, latitude, longitude] = input[i].split('|').filter(element => element);
        latitude = Number(latitude);
        longitude = Number(longitude);
        town["Town"] = townName.trim();
        town["Latitude"] = Number(latitude.toFixed(2));
        town["Longitude"] = Number(longitude.toFixed(2));
        result.push(town);
    }
    let myJson = JSON.stringify(result);
    console.log(myJson);
}


solve(['| Town | Latitude | Longitude |',
'| Sofia | 42.696552 | 23.32601 |',
'| Beijing | 39.913818 | 116.363625 |']
);