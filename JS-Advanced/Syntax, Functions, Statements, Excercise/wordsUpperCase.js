function wordsUppecCase(text){
    return text.match(/\w+/g).join(", ").toUpperCase();
}