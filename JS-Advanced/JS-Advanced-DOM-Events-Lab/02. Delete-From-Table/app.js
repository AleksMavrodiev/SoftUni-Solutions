function deleteByEmail() {
    let email = document.getElementsByName("email")[0].value;
    let secondCol = document.querySelectorAll("#customers tr td:nth-child(2)");
    let result = document.getElementById("result");
    for(let td of secondCol){
        if(td.textContent == email){
            let row = td.parentNode;
            row.parentNode.removeChild(row);
            result.textContent = "Deleted.";
            return;
        }
    }
    result.textContent = "Not found.";
}