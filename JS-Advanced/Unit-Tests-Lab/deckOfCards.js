function printDeckOfCards(cards) {
    let face = '';
    let suit = '';
    let result = [];
    for(let card of cards){
        face = card.length == 2 ? card[0] : card[0] + card[1];
        suit = card.length == 2 ? card[1] : card[2];
        let newCard = createCard(face, suit);
        result.push(newCard.toString());
    }

    console.log(result.join(" "));

    function createCard (face, suit){
        let validCards = ['2', '3', '4' ,'5' ,'6' ,'7' ,'8' ,'9','10','J','Q','K','A'];
        let validSuits = ['S', 'H', 'D', 'C'];
    
        if(validCards.indexOf(face) == -1 || validSuits.indexOf(suit) == -1){
            console.log(`Invalid card: ${face}${suit}`);
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
                return `${this.face}${this.suit} `;
            }
        };
    
        return card;
    }
 
}

printDeckOfCards(['AS', '10D', 'KH', '2C']);
  