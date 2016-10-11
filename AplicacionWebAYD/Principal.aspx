<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="AplicacionWebAYD.Principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <H1>PAGINA PRINCIPAL</H1>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="logoutButton" Text="Salir" runat="server" OnClick="logoutButton_Click" />  
        
    <asp:Label ID="userlabel" Text="No User" runat="server" />
</div>

        <div>


            <br />
            <br />
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
            <br />
            <br />
            <br />


        </div>


    </form>
</body>
</html>
