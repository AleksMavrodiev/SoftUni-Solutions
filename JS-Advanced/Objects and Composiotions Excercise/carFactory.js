function carFactory(carRequirements){
    let result = {};
    let smallEngine = {
        power: 90,
        volume: 1800
    };

    let normalEngine = {
        power: 120,
        volume: 2400
    };

    let monsterEngine = {
        power: 200,
        volume: 3500
    }

    result["model"] = carRequirements["model"];
    if(carRequirements.power <= 90){
        result.engine = smallEngine;
    }
    else if(carRequirements.power <= 120){
        result.engine = normalEngine;
    }
    else if(carRequirements.power <= 200){
        result.engine = monsterEngine;
    }

    result.carriage = {
        type: carRequirements["carriage"],
        color: carRequirements["color"]
    }

    let wheelSize = carRequirements.wheelsize % 2 == 0 ? carRequirements.wheelsize - 1 : carRequirements.wheelsize;

    result.wheels = new Array(4).fill(wheelSize);
    
    return result;
}

carFactory({ model: 'VW Golf II',
power: 90,
color: 'blue',
carriage: 'hatchback',
wheelsize: 14 }
);