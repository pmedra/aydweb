﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="AplicacionWebAYD.Principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <p>PAGINA PRINCIPAL</p>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="logoutButton" Text="Salir" runat="server" OnClick="logoutButton_Click" />  

    <asp:Label ID="userlabel" Text="No User" runat="server" />
</div>


    </form>
</body>
</html>