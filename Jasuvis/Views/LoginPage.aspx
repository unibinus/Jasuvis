<%@ Page Title="" Language="C#" MasterPageFile="~/Views/MasterPage.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="Jasuvis.Views.LoginPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Label ID="emailLbl" runat="server" Text="Email"></asp:Label>
        <asp:TextBox ID="emailTxt" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="passwordLbl" runat="server" Text="Password"></asp:Label>
        <asp:TextBox TextMode="Password" ID="passwordTxt" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:CheckBox ID="rememberMeChk" runat="server" Text="Remember Me"/>
    </div>
    <div>
        <asp:Label ID="errorLbl" runat="server" Text=""></asp:Label> 
    </div>
    <asp:Button ID="loginBtn" OnClick="loginBtn_Click" Text="Login" runat="server" />
</asp:Content>
