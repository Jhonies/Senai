const carrosselInner = document.getElementById('carrossel');
const imagens = carrosselInner.getElementsByTagName('img');
let currentIndex = 0;
const totalImagens = imagens.length;

function moveCarrossel() {
    currentIndex = (currentIndex + 3) % totalImagens; // Incrementa o índice e volta ao início
    const offset = -currentIndex * 33.3%; // Calcula o deslocamento
    carrosselInner.style.transform = `translateX(${offset}%)`; // Move o carrossel
}
