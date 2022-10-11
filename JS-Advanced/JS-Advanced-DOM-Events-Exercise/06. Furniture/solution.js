function solve() {
  let buttons = document.querySelectorAll("button");

  buttons[0].addEventListener('click', generate);
  buttons[1].addEventListener('click', buy);

  function generate(){
    let currentItems = JSON.parse(document.querySelectorAll("textarea")[0].value);
    let tableBody = document.getElementsByTagName("tbody")[0];
    for(let item of currentItems){
      let tableRow = document.createElement("tr");
      tableRow.innerHTML = `<td><img src="${item.img}"></td>` + 
                           `<td><p>${item.name}</p></td>` + 
                           `<td><p>${item.price}</p></td>` +
                           `<td><p>${item.decFactor}</p></td>` +
                           `<td><input type="checkbox"></td>`;
      tableBody.appendChild(tableRow);
    }
  }

  function buy(){
    let resultArea = document.querySelectorAll("textarea")[1];
    let rows = Array.from(document.querySelectorAll("tbody tr"));
    let res = {
      names: [],
      prices: [],
      decFactor: []
    }
    for(let el of rows){
      if(el.querySelector("input[type=checkbox]:checked")){
        let tableData = Array.from(el.querySelectorAll("td p"));
        res.names.push(tableData[0].textContent);
        res.prices.push(Number(tableData[1].textContent));
        res.decFactor.push(Number(tableData[2].textContent));
      }
    }

    let priceSum = res.prices.reduce((previousValue, currentValue) => previousValue + currentValue);
    let decSUm = res.decFactor.reduce((previousValue, currentValue) => previousValue + currentValue);
    debugger
    resultArea.value = `Bought furniture: ${res.names.join(', ')}\nTotal price: ${priceSum.toFixed(2)}\nAverage decoration factor: ${decSUm / res.decFactor.length}`
  }
}