var nombre = document.getElementById("nombre");
var apellido = document.getElementById("apellido");

function enviarFormulario(){

    console.log('Enviando formulario....')
    
    var mensajeError =[];

    if(nombre.value == null || nombre.value == ''){
        alert('Debe ingresar su nombre')
    }

    if(apellido.value == null || apellido.value == ''){
        alert('Debe ingresar su apellido')
    }
    return false;
}

function limpiarFormulario() {
    document.getElementById("formulario").reset();
  }



