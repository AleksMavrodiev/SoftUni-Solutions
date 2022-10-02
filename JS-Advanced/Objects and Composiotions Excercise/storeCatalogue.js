function storeCatalogue(input){
    input.sort();
    let catalogue = {};
    for(let data of input){
        let [item, price] = data.split(' : ');
        catalogue[item] = price;
    }

    let marker = '';
    for(const key in catalogue){
        if(key[0] != marker){
            marker = key[0];
            console.log(marker);
        }
        console.log(`${key}: ${catalogue[key]}`)
    }
}

storeCatalogue(['Appricot : 20.4',
'Fridge : 1500',
'TV : 1499',
'Deodorant : 10',
'Boiler : 300',
'Apple : 1.25',
'Anti-Bug Spray : 15',
'T-Shirt : 10']
);