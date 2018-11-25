window.onload = function() {
    document.getElementById('iniciar').onclick = doTimer;
}
// Variáveis Globais
var c = 1;
var t;
var timerLigado = 0;
// Condições para alterar a figura e animar a imagem
function timedCount() {
    if (c == 1) {
        document.getElementById('animar').src = "images/Capturar (1).png";
    }
    else if (c == 2) {
        document.getElementById('animar').src = "images/Capturar (2).png";
    }
    else if (c == 3) {
        document.getElementById('animar').src = "images/Capturar (3).png";
    }
    else if (c == 4) {
        document.getElementById('animar').src = "images/Capturar (4).png";
    }
    else if (c == 5) {
        document.getElementById('animar').src = "images/Capturar (5).png";
    }
    else if (c == 6) {
        document.getElementById('animar').src = "images/Capturar (6).png";
    }
    else if (c == 7) {
        document.getElementById('animar').src = "images/Capturar (7).png";
    }
    else if (c == 8) {
        document.getElementById('animar').src = "images/Capturar (8).png";
    }
    else if (c == 9) {
        document.getElementById('animar').src = "images/Capturar (9).png";
        c = 0;
    }
    // A cada intervalo de tempo, variável c aumenta em 1 seu valor
    c = c + 1;
    // Variável t recebe a função setTimeout que executará o código
    // na função timedCount a cada intervalo de tempo
    t = setTimeout("timedCount()",100);
}
    /* Função que checa se o timer já está correndo, evitando
    a criação de novos timer caso o botão seja pressionado mais
    de uma vez*/
    function doTimer() {
    if (!timerLigado) {
        timerLigado = 1;
        timedCount();
    }
}