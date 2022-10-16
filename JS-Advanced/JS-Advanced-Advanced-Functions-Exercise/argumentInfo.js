function solve(...params){
    let entries = {};

    for(let param of params){
        console.log(`${typeof(param)}: ${param}`);
        if(entries.hasOwnProperty(typeof(param))){
            entries[typeof(param)] ++;
        }
        else{
            entries[typeof(param)] = 1;
        }
    }

    let buff = ""
    for(let [key, value] of Object.entries(entries)){
        buff += `${key} = ${value}\n`;
    }

    console.log(buff);
}

solve('cat', 42, function () { console.log('Hello world!'); });