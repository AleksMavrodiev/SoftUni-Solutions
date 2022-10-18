function validate() {
  let documentForm = document.getElementById("registerForm");
  let companyButton = document.getElementById("company");
  let companyInfo = document.getElementById("companyInfo");

  companyButton.addEventListener("change", () => {
    if (companyButton.checked) {
      companyInfo.style.display = "block";
    } else {
      companyInfo.style.display = "none";
    }
  });

  documentForm.addEventListener("submit", (e) => {
    e.preventDefault();
    let allFieldsCorrect = true;
    let usernameInfo = document.getElementById("username");
    let usernamePattern = /^[A-Za-z0-9]{3,20}$/;
    if (usernamePattern.test(usernameInfo.value) == true) {
      usernameInfo.style.borderColor = "none";
    } else {
      usernameInfo.style.borderColor = "red";
      allFieldsCorrect = false;
    }

    let passwordPattern = /^[\w]{5,15}$/;
    let password = document.getElementById("password");
    let confirmPassword = document.getElementById("confirm-password");
    if (
      passwordPattern.test(password.value) == true &&
      passwordPattern.test(confirmPassword.value) == true &&
      password.value == confirmPassword.value
    ) {
      password.style.borderColor = "none";
      confirmPassword.style.borderColor = "none";
    } else {
      password.style.borderColor = "red";
      confirmPassword.style.borderColor = "red";
    }

    let emailPattern = /^[^@.]+@[^@]*\.[^@]*$/g;
    let email = document.getElementById("email");
    if (emailPattern.test(email.value) == true) {
      email.style.borderColor = "none";
    } else {
      email.style.borderColor = "red";
      allFieldsCorrect = false;
    }

    let companyNumberField = document.getElementById("companyNumber");
    let companyNumber = Number(document.getElementById("companyNumber").value);
    if (
      (companyNumber < 1000 || companyNumber > 9999) &&
      companyButton.ckecked
    ) {
      companyNumberField.style.borderColor = "red";
      allFieldsCorrect = false;
    } else {
      companyNumberField.style.borderColor = "none";
    }

    let validDiv = document.getElementById("valid");
    if (allFieldsCorrect) {
      validDiv.style.display = "block";
    } else {
      validDiv.style.display = "none";
    }
  });
}
