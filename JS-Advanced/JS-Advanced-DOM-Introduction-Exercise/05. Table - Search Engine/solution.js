function solve() {
   document.querySelector('#searchBtn').addEventListener('click', onClick);

   function onClick() {
      let input = document.getElementById("searchField").value.toLowerCase();
      let rowsArray = Array.from(document.querySelectorAll("tbody tr"));
      for(let row of rowsArray){
         row.className = '';
         let isFound = false;
         for(let col of row.children){
            if(row.innerText.toLowerCase().includes(input)){
               isFound = true;
            }
         }
         if(isFound){
            // row.style.cssText = `background-color: #FFF842;
            // color: #403E10;
            // font-weight: bold;
            // box-shadow: #7F7C21 -1px 1px, #7F7C21 -2px 2px, #7F7C21 -3px 3px, #7F7C21 -4px 4px, #7F7C21 -5px 5px, #7F7C21 -6px 6px;
            // transform: translate3d(6px, -6px, 0);
            
            // transition-delay: 0s;
            // transition-duration: 0.4s;
            // transition-property: all;
            // transition-timing-function: line;`
            row.className = "select";
         }
         
      }
      document.getElementById("searchField").value = "";
      
   }
}





