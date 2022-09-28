function addRemove(input){
    let number = 0;
    let result = [];
    for(let command of input){
        number++;
        switch(command){
            case 'add': result.push(number); break;
            case 'remove': result.pop(); break; 
        }
    }
    if(result.length === 0){
        console.log('Empty');
    }
    else{
        console.log(result.join('\n'));
    }
}

addRemove(['add', 
'add', 
'remove', 
'add', 
'add']
);