<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignIn.aspx.cs" Inherits="ProjetoMVC3B105.UI.SignIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Sign In</title>
    <link href="../styles/signin.css" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css2?family=Muli:wght@200;400;500&display=swap" rel="stylesheet">
</head>
<body>
    <div class="container">
        <form id="form1" runat="server">
            <h1>Entrar ao nosso sistema</h1>
            <div class="input-group">
                <asp:Label ID="status" runat="server" ForeColor="Red" Text="" Visible="false" />
            </div>
            <div class="input-group">
                <asp:Label ID="lblEmail" Text="Email" runat="server" CssClass="form-label" />
                <asp:TextBox runat="server" type="email" ID="txtEmail" CssClass="form-control" />
            </div>
            <div class="input-group">
                <asp:Label ID="lblPassword" Text="Senha" runat="server" CssClass="form-label" />
                <asp:TextBox runat="server" type="password" ID="txtPassword" CssClass="form-control" />
            </div>
            <div class="input-group">
                <asp:Button OnClick="btnEntrar_Click" ID="btnEntrar" CssClass="btn" runat="server" Text="Entrar" />
            </div>
        </form>
        <asp:Label CssClass="center" ID="lblAuthor" runat="server" />
    </div>
</body>
</html>
