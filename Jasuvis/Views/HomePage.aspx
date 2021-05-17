<%@ Page Title="" Language="C#" MasterPageFile="~/Views/MasterPage.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Jasuvis.Views.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="home-header">
        <div class="home-Jasuvis">
            Jasuvis
        </div>
        <div class="serviceProv-regis-button">
            <asp:Button ID="spRegisBtn" OnClick="spRegisBtn_Click" runat="server" Text="Sign Up As Service Provider" />
        </div>
        <div class="header-intro">
            Just Click One Button, and We Will Get Your Problems Done
        </div>
    </div>
    <div class="home-rec">
        <div class="rec-text">
            Recommended For You
        </div>
        <div class="card">
            <img src=""/>
            Supri
            Ahli Cuci AC
        </div>
    </div>
</asp:Content>
