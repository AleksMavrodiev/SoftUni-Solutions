function solve() {
  let text = document.getElementById("text").value;
  let namingConvention = document.getElementById("naming-convention").value;
  let result = ""
  let textArr = text.split(" ").filter(i => i);
  for(let i = 0; i < textArr.length; i++){
    if(namingConvention === "Camel Case"){
      if(i > 0){
        result += textArr[i].substring(0, 1).toUpperCase() + textArr[i].substring(1).toLowerCase();
      }
      else{
        result += textArr[i].toLowerCase();
      }
    }
    else if(namingConvention === "Pascal Case"){
      result += textArr[i].substring(0, 1).toUpperCase() + textArr[i].substring(1).toLowerCase();
    }
    else{
      result = "Error!"
    }
  }

  document.getElementById("result").textContent = result;
}