function heroicInventory(heroesData){
    let result = [];
    for(let heroeInfo of heroesData){
        let [heroName, heroLevel, heroItems] = heroeInfo.split(' / ');
        heroItems = heroItems ? heroItems.split(', ') : [];
        let hero = {
            name: heroName,
            level: Number(heroLevel),
            items: heroItems
        }
        result.push(hero);
    }
    let myJson = JSON.stringify(result);
    return myJson;
}

console.log(heroicInventory(['Isacc / 25 / Apple, GravityGun',
'Derek / 12 / BarrelVest, DestructionSword',
'Hes / 1 / Desolator, Sentinel, Antara']
));