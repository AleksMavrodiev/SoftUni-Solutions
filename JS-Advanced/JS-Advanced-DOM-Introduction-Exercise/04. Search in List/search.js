function search() {
   let input = document.getElementById("searchText").value;
   let cities = Array.from(document.querySelectorAll("ul li"));
   let count = 0;
   for(let town of cities){
      let text = town.textContent;
      if(text.includes(input)){
         town.style.textDecoration = "underline";
         town.style.fontWeight = "bold";
         count++;
      }
      else{
         town.style.textDecoration = "none";
         town.style.fontWeight = "normal";
      }
   }

   document.getElementById("result").innerText = `${count} matches found`;
}
