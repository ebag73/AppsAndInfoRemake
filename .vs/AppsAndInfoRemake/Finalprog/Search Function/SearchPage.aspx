<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchPage.aspx.cs" Inherits="Finalprog.WebForm1" %>

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
        left:50%;
        top:50%;
        transform: translateX(-50%) translateY(-50%);
        text-align: left;
        margin: 1px;
        }

        .outer {
        margin: 1px;
        display: inline-block;
        }</style>



        <div class ="center" >
               <div id ="searchBox">
                    <asp:TextBox class="outer" ID="txtSearch" runat="server" BorderStyle="Groove" Width="331px" Height="31px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;
                    <asp:Button class="outer" ID="btnSearch" runat="server" OnClick="btnSearch_Click" Text="Search" BorderStyle="Groove" Height="34px" Width="89px" />
                </div>
            </div>


        

            

            <asp:Button ID="btnLogout" runat="server" Height="25px" OnClick="btnLogout_Click" Text="Log Out" Width="130px" BorderStyle="None" />
            <asp:Button ID="btnAdmin" runat="server" OnClick="btnAdmin_Click" Text="AdminPage" Visible="False" BorderStyle="None" Height="25px" Width="130px" />
            <asp:Button ID="btnUser" runat="server" OnClick="btnUser_Click" Text="User Page" BorderStyle="None" Height="25px" Width="130px" />
&nbsp;<hr />
 
    </form>
</body>
</html>
