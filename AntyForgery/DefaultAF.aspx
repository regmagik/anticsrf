<%@ Page Title="Home Page" 
    Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DefaultAF.aspx.cs" Inherits="AntyForgery.DefaultAF" %>

<%--ValidateRequest="false" --%>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:Button Text="Save" runat="server" OnClick="Save_Click"/>
    <hr />
    <asp:Label ID="Label1" runat="server"></asp:Label>
    <asp:Label ID="lblPostback" runat="server"></asp:Label>


    <%= System.Web.Helpers.AntiForgery.GetHtml() %>
</asp:Content>
