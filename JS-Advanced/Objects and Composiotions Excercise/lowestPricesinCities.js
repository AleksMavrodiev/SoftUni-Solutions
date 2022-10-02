function lowestPrice(input){
    let result = {};

    for(let data of input){
        let [town, product, price] = data.split(' | ');
        price = Number(price);
        if(result.hasOwnProperty(product)){
            let currentPrice = result[product]["price"];
            if(currentPrice > price){
                result[product] = {town, price};
            }
        }
        else{
            result[product] = {town, price};
        }
    }

    for(let [product, value] of Object.entries(result)){
        console.log(`${product} -> ${value.price} (${value.town})`);
    }
}

