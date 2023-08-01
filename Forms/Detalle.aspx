<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Detalle.aspx.cs" Inherits="final_Valenzuela.Forms.Detalle" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Detalle</title>
</head>
<body>
    <form id="formDetalle" runat="server">
        <div>
            <label for="txtLegajo">Legajo:</label>
            <asp:TextBox ID="txtLegajo" runat="server"></asp:TextBox>
            <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
            <asp:HyperLink ID="lnkVolver" runat="server" Text="Volver a la página anterior" NavigateUrl="Default.aspx"></asp:HyperLink>
            <br />
            <asp:Label ID="lblMensaje" runat="server" Text="" Visible="false"></asp:Label>
            <br />
            <asp:Label ID="lblResultado" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
