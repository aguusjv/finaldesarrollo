window.onload = function () {

    // Asigno aplicarfoco - onmouseover
    var aceptarBoton = document.getElementById("btn_aceptar");
    aceptarBoton.onmouseover = AplicarFoco;
    var limpiarBoton = document.getElementById("btn_limpiar");
    limpiarBoton.onmouseover = AplicarFoco;

    // Asigno sacarfoco - onmouseout
    aceptarBoton.onmouseout = SacarFoco;
    limpiarBoton.onmouseout = SacarFoco;

    // Asigno limpiarcampos - onclick
    limpiarBoton.onclick = LimpiarCampos;

    }
  


function AplicarFoco() {
    this.className = "enfocada";
}

function SacarFoco() {
    this.className = "desenfocada";
}

function CambiarColor() {
    var miTabla = document.getElementById("miTabla");
    miTabla.style.backgroundColor = "#FFFF99";
}
function LimpiarCampos() {
    
    CambiarColor();
}