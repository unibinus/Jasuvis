<%@ Page Title="" Language="C#" MasterPageFile="~/Views/MasterPage.Master" AutoEventWireup="true" CodeBehind="ExplorePage.aspx.cs" Inherits="Jasuvis.Views.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="home-rec">
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
            </asp:Repeater>
        </div>
    </div>
</asp:Content>
