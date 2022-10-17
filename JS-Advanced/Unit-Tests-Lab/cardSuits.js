function printCards(face, suit){
    let validCards = ['2', '3', '4' ,'5' ,'6' ,'7' ,'8' ,'9','10','J','Q','K','A'];
    let validSuits = ['S', 'H', 'D', 'C'];

    if(validCards.indexOf(face) == -1 || validSuits.indexOf(suit) == -1){
        throw Error("Error");
    }

    switch(suit){
        case 'S': suit = '\u2660'; break;
        case 'H': suit = '\u2665'; break;
        case 'D': suit = '\u2666'; break;
        case 'C': suit = '\u2663'; break;
    }

    let card = {
        face: face,
        suit: suit,
        toString: function(){
            return `${this.face}${this.suit}`;
        }
    };

    return card;
}

let card = printCards('1', 'C');
console.log(card.toString());