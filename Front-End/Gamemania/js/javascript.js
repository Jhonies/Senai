const carrosselInner = document.getElementById('carrossel');
const imagens = carrosselInner.getElementsByTagName('img');
let currentIndex = 0;
const totalImagens = imagens.length;

function moveCarrossel() {
    currentIndex = (currentIndex + 3) % totalImagens; // Incrementa o índice e volta ao início
    const offset = -currentIndex * 33.3%; // Calcula o deslocamento
    carrosselInner.style.transform = `translateX(${offset}%)`; // Move o carrossel
}
//Centraliza o href ao clicar
function centralizarSeção(event, id) {
    event.preventDefault(); // Impede o comportamento padrão do link
    
    const elemento = document.getElementById(id);
  
    // Calcula a posição vertical que vai centralizar o elemento na tela
    const posicaoElemento = elemento.offsetTop;
    const alturaJanela = window.innerHeight;
    const alturaElemento = elemento.offsetHeight;
  
    // Posição do topo para centralizar o elemento na tela
    const posicaoCentralizada = posicaoElemento - (alturaJanela / 2) + (alturaElemento / 2);
  
    // Faz o scroll suave até a posição calculada
    window.scrollTo({
      top: posicaoCentralizada,
      behavior: 'smooth'
    });
  }
  