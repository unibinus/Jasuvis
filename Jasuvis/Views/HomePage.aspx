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
                <asp:Button ID="RegisBtn" OnClick="RegisBtn_Click" runat="server" Text="Register Here" />
            </div>
        </div>  
        <div class="headerSVG">
            <asp:Image ID="image" runat="server" ImageUrl="~/Assets/MonitorClean.svg" class="headerImg"/>
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
            <asp:Repeater ID="recommendServiceProvider" runat="server">
                <ItemTemplate>
                    <div class="card sp-card">
                        <asp:Image ID="image" runat="server" ImageUrl='<%# Eval("serviceProviderPhoto") %>' class="sp-mage"/>
                        <asp:Label ID="serviceProviderNameLbl" class="sp-name" runat="server" Text='<%# Eval("serviceProviderName") %>' ></asp:Label>
                        <asp:Label ID="serviceNameLbl" class="sp-work" runat="server" Text='<%# Eval("ServiceName") %>'></asp:Label>
                        <asp:Label ID="serviceTypeLbl" class="sp-name" runat="server" Text='<%# Eval("serviceTypeName") %>' ></asp:Label>
                    </div>
                </ItemTemplate>
            </asp:Repeater
        </div>
    </div>
</asp:Content>
