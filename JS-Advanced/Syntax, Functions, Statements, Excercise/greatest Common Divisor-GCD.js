function gcd(x, y){
    function greatestCommonDivider(x, y){
        if(!y){
            return x;
        }
    
        return greatestCommonDivider(y, x % y);
    }
    console.log(greatestCommonDivider(x, y));
}

gcd(15, 5);