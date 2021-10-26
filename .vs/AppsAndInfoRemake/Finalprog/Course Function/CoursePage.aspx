<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CoursePage.aspx.cs" Inherits="Finalprog.CoursePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnLogout" runat="server" Height="25px" OnClick="btnLogout_Click" Text="Log Out" Width="130px" BorderStyle="None" />
            
            <asp:Button ID="btnAdmin" runat="server" OnClick="btnAdmin_Click" Text="AdminPage" Visible="False" BorderStyle="None" Height="25px" Width="130px" />
            <asp:Button ID="btnUser" runat="server" OnClick="btnUser_Click" Text="User Page" BorderStyle="None" Height="25px" Width="130px" />
&nbsp;<hr />
            <br />
            <br />
            <br />
            <asp:Label ID="lblCourse" runat="server" Style="font-weight: 700; font-size: xx-large" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Button ID="testButton" runat="server" Height="46px" OnClick="testButton_Click" Text="Take Test" Width="85px" />
            <asp:Panel ID="Panel1" runat="server" Height="19px">
                <asp:Label ID="announceLabel" runat="server" Text="Annoucment"></asp:Label>
            </asp:Panel>
            <asp:Panel ID="test" runat="server" Height="246px">
                <asp:Panel ID="Panel2" runat="server">
                    <asp:Label ID="descriptionLabel" runat="server" Text="Discription"></asp:Label>
                    <asp:Panel ID="Panel3" runat="server">
                        <asp:Label ID="zoomLabel" runat="server" Text="Zoom"></asp:Label>
                        <asp:Panel ID="Panel4" runat="server">
                            <asp:Label ID="teachLabel" runat="server" Text="Teacher"></asp:Label>
                        </asp:Panel>
                    </asp:Panel>
                </asp:Panel>
            </asp:Panel>
            <br />
            <br />
            <br />
        </div>

        <div class="form-group">
        </div>
    </form>
</body>
</html>
