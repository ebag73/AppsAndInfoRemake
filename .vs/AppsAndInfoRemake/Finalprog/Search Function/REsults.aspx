<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Results.aspx.cs" Inherits="Finalprog.REsults" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">


        <style>
            .center {
                position: absolute;
                left: 49%;
                top: 17%;
                transform: translateX(-50%) translateY(-50%);
                text-align: left;
                margin: 1px;
            }

            .center2 {
                position: absolute;
                left: 50%;
                top: 50%;
                transform: translateX(-50%) translateY(-40%);
                text-align: left;
                margin: 1px;
            }

            .center3 {
                position: absolute;
                left: 50%;
                top: 33%;
                transform: translateX(-50%) translateY(-40%);
                text-align: left;
                margin: 1px;
            }

            .outer {
                margin: 1px 1px 1px 0px;
                display: inline-block;
            }
        </style>

        <asp:Button ID="btnLogout" runat="server" Height="25px" OnClick="btnLogout_Click" Text="Log Out" Width="130px" BorderStyle="None" />
        <asp:Button ID="btnAdmin" runat="server" OnClick="btnAdmin_Click" Text="AdminPage" Visible="False" BorderStyle="None" Height="25px" Width="130px" />
        <asp:Button ID="btnUser" runat="server" OnClick="btnUser_Click" Text="User Page" BorderStyle="None" Height="25px" Width="130px" />
        &nbsp;<hr />
        <div class="center">
            <asp:TextBox class="outer" ID="txtResultsSearch" runat="server" Width="637px" Height="27px" BorderStyle="Outset"></asp:TextBox>
            <asp:Button class="outer" ID="btnResultsSearch" runat="server" OnClick="btnResultsSearch_Click" Text="Search" Height="33px" Width="136px" />
        </div>

        <div class="center2">
            <asp:ListBox ID="lstResults" runat="server" Width="633px" Height="324px" Font-Names="Roboto Condensed" Font-Size="Large"></asp:ListBox>
        </div>
        <div class="center3">
            <asp:Button ID="btnCourse" runat="server" Text="Go To Course" OnClick="btnCourse_Click" Font-Names="Roboto Condensed" Font-Size="Large" Width="631px" Height="40px" />
        </div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblSelect" runat="server" ForeColor="#CC0000" Text="Please Select a Course" Visible="False"></asp:Label>
        </p>
    </form>
</body>
</html>
