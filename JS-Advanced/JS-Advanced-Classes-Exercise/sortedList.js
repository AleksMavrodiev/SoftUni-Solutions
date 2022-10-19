class List{
    constructor(){
        this.elements = [];
        this.size = 0;
    }

    

    sortingList(){
        this.elements.sort((a, b) => a - b);
    }

    add(element){
        this.elements.push(element);
        this.size++;
        this.sortingList();
    }

    remove(index){
        if(index < 0 || index >= this.size){
            throw Error("Invalid index");
        }
        this.elements.splice(index, 1);
        this.size--;
        this.sortingList();
    }

    get(index){
        if(index < 0 || index >= this.elements.length){
            throw Error("Invalid index");
        }
        return this.elements[index]; 
    }
}

let list = new List();
list.add(5);
list.add(6);
list.add(7);
console.log(list.get(1)); 
list.remove(1);
console.log(list.get(1));
