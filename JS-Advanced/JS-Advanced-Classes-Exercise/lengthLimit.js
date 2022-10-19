class Stringer{
    constructor(innerText, innerLength){
        this.innerText = innerText;
        this.innerLength = innerLength;
    }

    increase(value){
        this.innerLength += value;
    }

    decrease(value){
        this.innerLength -= value;
        if(this.innerLength < 0){
            this.innerLength = 0;
        }
    }

    toString(){
        let result = this.innerText;
        if(this.innerText.length > this.innerLength){
            let elementsToRemove = this.innerText.length - this.innerLength;
            result = result.slice(0, result.length - elementsToRemove);
            result += "...";
            return result;
        }
        return this.innerText;
    }
}

let test = new Stringer("Test", 5);
console.log(test.toString()); // Test

test.decrease(3);
console.log(test.toString()); // Te...

test.decrease(5);
console.log(test.toString()); // ...

test.increase(4); 
console.log(test.toString()); // Test
