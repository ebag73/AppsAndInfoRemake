<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForgotPassword.aspx.cs" Inherits="Finalprog.ForgotPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="font-size: x-large">
    <form id="form1" runat="server">
        <p>
            Enter Your Email Address:</p>
        <p>
            <asp:TextBox ID="txtEmail" runat="server" Height="20px" Width="250px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnSend" runat="server" OnClick="btnSend_Click" Text="Send Recovery #" Width="112px" />
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblConfirm" runat="server" Text="Recovery #:" Visible="False"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtConfirm" runat="server" Visible="False"></asp:TextBox>
&nbsp;
            <asp:Button ID="btnComfirm" runat="server" OnClick="btnComfirm_Click" Text="Confirm" Visible="False" />
        </p>
        <p>
            <asp:Label ID="lblFalse" runat="server" Text="Incorrect Recovery #" Visible="False"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblNew" runat="server" Text="New Password: " Visible="False"></asp:Label>
&nbsp;<asp:TextBox ID="txtNew" runat="server" Visible="False"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblNewConfirm" runat="server" Text="Confirm Password:" Visible="False"></asp:Label>
&nbsp;
            <asp:TextBox ID="txtNewConfirm" runat="server" Visible="False"></asp:TextBox>
&nbsp;&nbsp;
            <asp:Button ID="btnConfirmNew" runat="server" OnClick="btnConfirmNew_Click" Text="Confrim" Visible="False" />
        </p>
        <p>
            <asp:Label ID="lblChanged" runat="server" ForeColor="#00CC00" Text="Password Changed" Visible="False"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnReturn" runat="server" OnClick="btnReturn_Click" Text="Return to Login" />
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
