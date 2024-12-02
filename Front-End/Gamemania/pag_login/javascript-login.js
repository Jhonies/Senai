const validUsername = "admin123";
const validPassword = "senha123";

function validateLogin() {
    const username = document.getElementById("username").value;
    const password = document.getElementById("password").value;
    const message = document.getElementById("result");

    if (username === validUsername && password === validPassword) {
        message.textContent = "Login bem-sucedido!";
        message.style.color = "white";
        window.location.href = "../index.html";
    } else {
        message.textContent = "Usuário ou senha incorretos.";
        message.style.color = "pink";
    }
}