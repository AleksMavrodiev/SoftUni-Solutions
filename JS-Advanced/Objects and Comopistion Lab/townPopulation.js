function townPopulation(input){
    let townData = input.map(element => {
        let date = element.split(' <-> ');

        return {
            name: date[0],
            population: Number(date[1])
        };
    });

    let registry = {};

    for(let town of townData){
        if(registry[town.name] != undefined){
            registry[town.name] += town.population;
        }
        else{
            registry[town.name] = town.population;
        }
    }

    for(let town in registry){
        console.log(`${town} : ${registry[town]}`);
    }
}

townPopulation(['Sofia <-> 1200000',
'Montana <-> 20000',
'New York <-> 10000000',
'Washington <-> 2345000',
'Las Vegas <-> 1000000']
);