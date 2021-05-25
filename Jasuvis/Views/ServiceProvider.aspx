<%@ Page Title="" Language="C#" MasterPageFile="~/Views/MasterPage.Master" AutoEventWireup="true" CodeBehind="ServiceProvider.aspx.cs" Inherits="Jasuvis.Views.DetailServiceProvider" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Image ID="img" runat="server" ImageUrl='<%# Eval("serviceProviderPhoto") %>'/>

        <p>Name: </p>
        <asp:Label ID="lblName" runat="server" Text='<%# Eval("serviceProviderName") %>'></asp:Label>
        <br />

        <p>Service Name: </p>
        <asp:Label ID="lblServiceName" runat="server" Text='<%# Eval("servicename") %>'></asp:Label>
        <br />

        <p>Service Type: </p>
        <asp:Label ID="lblServiceType" runat="server" Text='<%# Eval("serviceTypeName") %>'></asp:Label>
        <br />

        <br />
    </div>
</asp:Content>
