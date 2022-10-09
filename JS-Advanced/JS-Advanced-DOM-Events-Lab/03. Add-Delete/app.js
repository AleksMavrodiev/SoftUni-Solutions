function addItem() {
    let itemText = document.getElementById("newItemText").value;
    let list = document.getElementById("items");
    let li = document.createElement("li");
    if(itemText.length === 0){
        return;
    }
    li.textContent = itemText;
    let remove = document.createElement("a");
    let linkText = document.createTextNode("[Delete]");
    remove.appendChild(linkText);
    remove.href = "#";
    remove.addEventListener('click', deleteItem);

    li.appendChild(remove);
    list.appendChild(li);
    function deleteItem(){
        li.remove();
    }
}