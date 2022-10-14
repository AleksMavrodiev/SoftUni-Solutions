function solve(area, vol, input) {
    let result = [];
    let data = JSON.parse(input);
    for(let object of data){
        let objectArea = area.call(object);
        let objectVolume = vol.call(object);
        result.push({
            area: objectArea,
            volume: objectVolume
        });
    }

    return result;
}


function vol() {
    return Math.abs(this.x * this.y * this.z);
};


function area() {
    return Math.abs(this.x * this.y);
};

console.log(solve(area, vol, `[
    {"x":"1","y":"2","z":"10"},
    {"x":"7","y":"7","z":"10"},
    {"x":"5","y":"2","z":"10"}
    ]`
    ));
