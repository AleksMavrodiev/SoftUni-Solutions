function sortTickets(tickets, sortParam){
    class Ticket{
        constructor(destination, price, status){
            this.destination = destination;
            this.price = price;
            this.status = status;
        }
    }

    let result = [];

    for(let ticketData of tickets){
        let [destination, price, status] = ticketData.split('|');
        let ticket = new Ticket(destination, Number(price), status);
        result.push(ticket);
    }

    switch(sortParam){
        case "destination": result.sort((a, b) => a.destination.localeCompare(b.destination)); break;
        case "price": result.sort((a, b) => a.price - b.price); break;
        case "status": result.sort((a, b) => a.status.localeCompare(b.status)); break;
    }

    return result;
}

console.log(sortTickets(['Philadelphia|94.20|available',
'New York City|95.99|available',
'New York City|95.99|sold',
'Boston|126.20|departed'],
'status'
));