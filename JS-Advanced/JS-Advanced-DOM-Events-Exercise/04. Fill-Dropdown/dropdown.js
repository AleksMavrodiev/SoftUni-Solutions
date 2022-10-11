function addItem() {
    let textField = document.getElementById("newItemText");
    let valueField = document.getElementById("newItemValue");
    let dropDown = document.getElementById("menu");

    let option = document.createElement("option");
    option.textContent = textField.value;
    option.value = valueField.value;
    dropDown.appendChild(option);
    textField.value = '';
    valueField.value = '';
}