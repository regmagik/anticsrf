<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="AntyForgery.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:Button Text="Login as Admin" runat="server" OnClick="Admin_Click"/>
    <asp:Button Text="Login as Guest" runat="server" OnClick="Guest_Click"/>
    </form>
</body>
</html>
