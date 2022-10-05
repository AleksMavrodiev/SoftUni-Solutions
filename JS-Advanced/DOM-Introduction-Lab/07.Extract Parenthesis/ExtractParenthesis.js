function extract(content) {
    let elementText = document.getElementById(content).textContent;
    let pattern = /\(([^)]+)\)/g;
    let result = elementText.matchAll(pattern);
    let matches = [];
    let match = pattern.exec(para);
    
    for(let text of result){
        matches.push(text[1]);
    }


    return result.join('; ');
    
}