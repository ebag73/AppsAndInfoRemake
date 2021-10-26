<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Finalprog.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: larger;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align: center; font-size: xx-large">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>&nbsp; </strong><span class="auto-style1"><strong>Onstitute </strong></span>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" ForeColor="Red" style="font-size: large" Text="Username or Password Incorrect" Visible="False"></asp:Label>
            <br />
            Username: <asp:TextBox ID="txtuser" runat="server" Height="20px" OnTextChanged="TextBox1_TextChanged" Width="160px"></asp:TextBox>
            <br />
            <br />
            <br />
            Password: <asp:TextBox ID="txtpass" runat="server" Height="20px" OnTextChanged="TextBox1_TextChanged" Width="160px"></asp:TextBox>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="hyperForgot" runat="server" style="font-size: small" NavigateUrl="~/User Function/ForgotPassword.aspx">Forgot Password?</asp:HyperLink>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnLogin" runat="server" Height="32px" OnClick="btnLogin_Click" Text="Log In" Width="91px" />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnCreate" runat="server" Height="32px" OnClick="btnCreate_Click" Text="Create Account" Width="106px" />
            <br />
        </div>
    </form>
</body>
</html>
