<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="Finalprog.User_Function.Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnLogout" runat="server" Height="25px" OnClick="btnLogout_Click" Text="Log Out" Width="130px" BorderStyle="None" />
            <asp:Button ID="btnCourse" runat="server" OnClick="btnCourse_Click" Text="Course Search" BorderStyle="None" Height="25px" Width="130px" />
            <asp:Button ID="btnUser" runat="server" OnClick="btnUser_Click" Text="User Page" BorderStyle="None" Height="25px" Width="130px" />
&nbsp;<hr />
        </div>
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="username" HeaderText="username" SortExpression="username" />
                <asp:BoundField DataField="first_name" HeaderText="first_name" SortExpression="first_name" />
                <asp:BoundField DataField="last_name" HeaderText="last_name" SortExpression="last_name" />
                <asp:BoundField DataField="phone_number" HeaderText="phone_number" SortExpression="phone_number" />
                <asp:BoundField DataField="degree" HeaderText="degree" SortExpression="degree" />
                <asp:BoundField DataField="organization" HeaderText="organization" SortExpression="organization" />
                <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
                <asp:BoundField DataField="status" HeaderText="status" SortExpression="status" />
                <asp:BoundField DataField="RoleID" HeaderText="Role " SortExpression="RoleID" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:UsersConnectionString %>" SelectCommand="SELECT [username], [first_name], [last_name], [phone_number], [degree], [organization], [email], [status], [RoleID] FROM [user] ORDER BY [username]"></asp:SqlDataSource>
        <br />
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource2">
            <Columns>
                <asp:BoundField DataField="description" HeaderText="description" SortExpression="description" />
                <asp:BoundField DataField="professorName" HeaderText="professorName" SortExpression="professorName" />
                <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                <asp:BoundField DataField="lectureHours" HeaderText="lectureHours" SortExpression="lectureHours" />
                <asp:BoundField DataField="credits" HeaderText="credits" SortExpression="credits" />
                <asp:BoundField DataField="review" HeaderText="review" SortExpression="review" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:UsersConnectionString %>" SelectCommand="SELECT [description], [professorName], [name], [lectureHours], [credits], [review] FROM [Classes]"></asp:SqlDataSource>
    </form>
</body>
</html>
