function addItem() {
    let textValue = document.getElementById("newItemText").value;
    let li = document.createElement('li');
    li.textContent = textValue;
    let list = document.getElementById("items");
    list.appendChild(li);
}