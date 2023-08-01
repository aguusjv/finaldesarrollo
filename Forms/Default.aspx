<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="final_Valenzuela.Forms.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Registro de Empleados</title>
    <script src="../JavaScript/Funciones.js"></script>
    <script src="../JavaScript/validacion.js"></script>
    <link href="../CSS/Estilos.css" rel="stylesheet" />
</head>
<body>
    <div class="recuadro-externo">
        <form id="RegistroEmpleados" runat="server">
            <div>
                <table id="miTabla">
                    <tr>
                    <th colspan="5"><span>Registro de Empleados</span></th>
                </tr>
                <tr>
                    <td><span class="personal"><asp:Label CssClass="personal" ID="apellidoLabel" runat="server" Text="Apellido"></asp:Label></span></td>
                    <td><span class="personal"><asp:Label CssClass="personal" ID="nombreLabel" runat="server" Text="Nombre"></asp:Label></span></td>
                </tr>
                <tr>                
                    <td><span class="personal"><asp:TextBox Type="text" ID="apellidoTextbox" runat="server"></asp:TextBox></span></td>
                    <td><span class="personal"><asp:TextBox Type="text" ID="nombreTextbox" runat="server"></asp:TextBox></span></td>
                </tr>
                <tr>
                    <td><span class="empresariales"><asp:Label CssClass="empresariales" ID="legajoLabel" runat="server" Text="Legajo"></asp:Label></span></td>
                    <td><span class="empresariales"><asp:Label CssClass="empresariales" ID="categoriaLabel" runat="server" Text="Categoria"></asp:Label></span></td>
                </tr>
                <tr>
                    <asp:Label ID="errorLabel" runat="server" ForeColor="Red" Visible="false"></asp:Label>
                </tr>
                <tr>
                    <td><span class="empresariales"><asp:TextBox Type="text" ID="legajoTextbox" runat="server"></asp:TextBox></span></td>
                    <td><span class="empresariales"><asp:TextBox Type="text" ID="CategoriaTextbox" runat="server"></asp:TextBox></span></td>
                </tr>
                <tr>
                    <td>
                        <span class="desenfocada boton_limpiar">
                            <asp:Button CssClass="desenfocada boton_limpiar" ID="btn_limpiar" runat="server" Text="Limpiar" OnClientClick="return limpiarCampos()" OnClick="btn_limpiar_Click" ClientIDMode="Static" />
                        </span>
                    </td>
                    <td>
                        <span class="desenfocada boton_aceptar">                        
                            <asp:Button CssClass="desenfocada boton_aceptar" ID="btn_aceptar" runat="server" Text="Aceptar" OnClientClick="return validateForm()" OnClick="btn_aceptar_Click" ClientIDMode="Static" />
                        </span>
                    </td>                
                </tr>
                </table>
            </div>
        </form>
    </div>
</body>
</html>
