//validacion para no permitir campos en blanco
function validarForm() {
    var apellido = document.getElementById('<%= apellidoTextbox.ClientID %>').value;
    var nombre = document.getElementById('<%= nombreTextbox.ClientID %>').value;
    var legajo = document.getElementById('<%= legajoTextbox.ClientID %>').value;
    var categoria = document.getElementById('<%= CategoriaTextbox.ClientID %>').value;

    if (apellido.trim() === '' || nombre.trim() === '' || legajo.trim() === '' || categoria.trim() === '') {
        document.getElementById('<%= errorLabel.ClientID %>').innerHTML = 'Por favor, complete todos los campos.';
        document.getElementById('<%= errorLabel.ClientID %>').style.display = 'block';
        return false;
    } else {
        document.getElementById('<%= errorLabel.ClientID %>').style.display = 'none';
        return true;
    }
}