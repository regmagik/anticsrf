<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="AntyForgery.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>About</h2>
    <h3>Test CSRF problem and solution.</h3>
    <p>Use this area to provide additional information.</p>
    <p>Logged in as <%: User.Identity.Name %></p>
    <p>
         <a href="/DefaultAF">Protected with AntiForgery</a> Protected with AntiForgery library, token embedded in a page, validated in Save_Click.
    </p>
    <p>
         <a href="/DefaultB">Protected with Base Class</a> Protected and validated with AntiForgery library, in the base class. (Recommended method)
    </p>
    <p>
         <a href="/DefaultMP">Protected with Master</a> - Protected using the Master page (based on the code from Visual Studio ASP.NET project.
    </p>
</asp:Content>
