function notify(message) {
  let divContent = document.getElementById("notification");
  divContent.textContent = message;
  divContent.style.display = "block";
  divContent.addEventListener('click', toggleNotification);

  function toggleNotification(event){
    event.target.style.display = "none";
  }
}