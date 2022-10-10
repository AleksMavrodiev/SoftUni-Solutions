function create(words) {
   let mainDiv = document.getElementById("content");
   for(let word of words){
      let div = document.createElement("div");
      div.addEventListener('click', displayText)
      let p = document.createElement("p");
      p.innerText = word;
      p.style.display = 'none';
      div.appendChild(p);
      mainDiv.appendChild(div);
   }

   function displayText(event){
      let targetP = event.target.children[0];
      if(targetP.style.display != 'none'){
         return;
      }
      targetP.style.display = 'block';
   }
}