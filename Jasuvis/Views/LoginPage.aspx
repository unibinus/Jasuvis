<%@ Page Title="" Language="C#" MasterPageFile="~/Views/MasterPage.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="Jasuvis.Views.LoginPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="form-group col-md-6">
        <asp:Button ID="registerBtn" Text="Register Here" runat="server" class="btn btn-link"/> 
    </div>

    <div class="form-group col-md-6">
        <asp:Label ID="emailLbl" runat="server" Text="Email"></asp:Label>
        <asp:TextBox ID="emailInput" runat="server"></asp:TextBox>
    </div>
    <div class="form-group col-md-6">
        <asp:Label ID="passwordLbl" runat="server" Text="Password"></asp:Label>
        <asp:TextBox TextMode="Password" ID="passwordInput" runat="server"></asp:TextBox>
    </div>

    <div class="form-group col-md-6">
        <div class="form-check">
            <asp:CheckBox ID="RememberMeCheckbox" runat="server" class="form-check-input" text="Remember Me"/>
        </div>
    </div> 
    <br />

    <div class="form-group col-md-6">
        <asp:Button ID="loginBtn" OnClick="loginBtn_Click" Text="Login" runat="server" class="btn" /> 
    </div>

    <div class="form-group col-md-6">
        <asp:Label ID="labelError" runat="server" Text=""></asp:Label> 
    </div> 
</asp:Content>
