function solve() {
  let textArea = document.getElementById("input").value;
  let output = document.getElementById("output");
  output.innerHTML = "";
  let sentences = textArea.split(".").filter(x => x.length > 0);
  for(let i = 0; i < sentences.length; i+=3){
    let res = [];
    for(let x = 0; x < 3; x++){
      if(sentences[i + x]){
        res.push(sentences[i + x]);
      }
    }

    let resText = res.join(". ") + ".";
    output.innerHTML += `<p>${resText}</p>`
  }
}