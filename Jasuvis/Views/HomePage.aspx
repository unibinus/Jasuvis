<%@ Page Title="" Language="C#" MasterPageFile="~/Views/MasterPage.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Jasuvis.Views.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="home-header">
        <div class="header-Jasuvis-Group">
            <div class="home-Jasuvis-text">
                Jasuvis
            </div>
            <div class="serviceProv-regis-button btn">
                <asp:Button ID="spRegisBtn" OnClick="spRegisBtn_Click" runat="server" Text="Sign Up As Service Provider" />
            </div>
        </div>  
        <div class="header-intro">
            Just Click One Button, and We Will Get Your Problems Done
        </div>
    </div>

    <div class="home-rec">
        <div class="rec-text">
            Recommended For You
        </div>
        <div class="carousel">
            <asp:Repeater ID="Repeater" runat="server">
                <ItemTemplate>
                    <div class="card sp-card">
                        <asp:Image ID="image" runat="server" ImageUrl='<%# Eval("ProfilePicture") %>' class="spImage"/>
                        <asp:Label ID="nameLbl" class="sp-name" runat="server" Text='<%# Eval("Name") %>' class="spName"></asp:Label>
<%--                        <asp:Label ID="serviceLbl" class="sp-work" runat="server" Text='<%# Eval("ServiceName") %>'></asp:Label>--%>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
            
           <%-- <div class="card sp-card">
                <img src=""/>
                <div class="sp-name">Supri</div>
                <div class="sp-work">Ahli Cuci AC</div>
            </div>
            <div class="card sp-card">
                <img src=""/>
                <div class="sp-name">Supri</div>
                <div class="sp-work">Ahli Cuci AC</div>
            </div>
            <div class="card sp-card">
                <img src=""/>
                <div class="sp-name">Supri</div>
                <div class="sp-work">Ahli Cuci AC</div>
            </div>--%>
        </div>
    </div>
</asp:Content>
