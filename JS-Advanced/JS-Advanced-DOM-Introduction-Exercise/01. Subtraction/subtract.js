function subtract() {
    let firstElement = Number(document.getElementById("firstNumber").value);
    let secondNumber = Number(document.getElementById("secondNumber").value);
    let result = firstElement - secondNumber;
    let area = document.getElementById("result");
    area.textContent = result;
}