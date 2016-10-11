<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AplicacionWebAYD.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Pagina de Inicio</h1>
    <a href="#">Home </a>

    <form id="form1" runat="server">



    <div>
        <h3>Ingrese Usuario</h3>
        <asp:Textbox ID="usernameTextBox" runat="server" />

        <h3>Ingrese Contraseña</h3>
        <asp:Textbox ID="passwordTextBox" TextMode="Password" runat="server" />
        <br />  
        <asp:Button ID="submitButton"  Text="Ingresar" runat="server" OnClick="submitButton_Click"  />
     </div>


        <div>



        </div>



    </form>
</body>
</html>
