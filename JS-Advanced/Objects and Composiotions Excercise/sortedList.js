function createSortedList(){
    let obj = {
        numbers: [],
        size: this.numbers.length,
        add: function(element){
            this.numbers.push(element);
            this.numbers.sort((a, b) => a - b);
        },
        remove: function(index){
            if(index < 0 || index >= this.numbers.length){
                return;
            }
            this.numbers.splice(index , 1);
        },
        get: function(index){
            if(index < 0 || index >= this.numbers.length){
                return;
            }
            return this.numbers[index];
        }

    }
    return obj;
}

let list = createSortedList();
list.add(5);
list.add(6);
list.add(7);
console.log(list.get(1)); 
list.remove(1);
console.log(list.get(1));
