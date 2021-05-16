<%@ Page Title="" Language="C#" MasterPageFile="~/Views/MasterPage.Master" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="Jasuvis.Views.RegisterPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        Register
    </div>
    <div>
        <asp:Label ID="emailLbl" runat="server" Text="Email"></asp:Label>
        <asp:TextBox ID="emailTxt" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="passwordLbl" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="passwordTxt" TextMode="Password" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="nameLbl" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="nameTxt" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="phoneLbl" runat="server" Text="Phone Number"></asp:Label>
        <asp:TextBox ID="phoneTxt" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="genderLbl" runat="server" Text="Gender"></asp:Label>
        <asp:RadioButton ID="maleRadio" GroupName="gender" Text="Male" runat="server" />
        <asp:RadioButton ID="femaleRadio" GroupName="gender" Text="Female" runat="server" />
    </div>
    <div>
        <asp:Label ID="addressLbl" runat="server" Text="Address"></asp:Label>
        <asp:TextBox ID="addressTxt" TextMode="MultiLine" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="serviceProviderlbl" runat="server" Text="Are you a service provider?"></asp:Label>
        <asp:RadioButton ID="serviceProviderBtnYes" GroupName="serviceProvider" Text="Yes" runat="server" />
        <asp:RadioButton ID="serviceProviderBtnNo" GroupName="serviceProvider" Text="No" runat="server" />
    </div>
    <div>
        <asp:Label ID="errorLbl" runat="server" ForeColor="Red" Text=""></asp:Label>
    </div>
    <asp:Button ID="RegisterBtn" OnClick="RegisterBtn_Click" runat="server" Text="Register" />
</asp:Content>
