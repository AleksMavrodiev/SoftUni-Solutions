function solve(){
    document.querySelector('#buttonSnd').addEventListener('click', onClick);
    function onClick() {
        let inputNum = Number(document.getElementById("input").value);
        let convertTo = document.getElementById("selectMenuTo").value;
        let result = 0;
        switch(convertTo){
            case 'binary': result = inputNum.toString(2); break;
            case 'hexadecimal': result = inputNum.toString(16); break;
        }
    
        document.getElementById("result").value = result;
    }
}

