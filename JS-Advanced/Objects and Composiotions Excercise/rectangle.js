function rectangle(widthValue, heightValue, colorValue){
    return{
        width: widthValue,
        height: heightValue,
        color: colorValue[0].toUpperCase() +  colorValue.substring(1),
        calcArea: function(){
            return this.width * this.height;
        } 
    }
}

let rect = rectangle(4, 5, 'red');
console.log(rect.width);
console.log(rect.height);
console.log(rect.color);
console.log(rect.calcArea());
