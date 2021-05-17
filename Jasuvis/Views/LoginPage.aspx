<%@ Page Title="" Language="C#" MasterPageFile="~/Views/MasterPage.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="Jasuvis.Views.LoginPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-sm-9 col-md-7 col-lg-5 mx-auto">
                <div class="card card-signin my-5">
                    <div class="card-body">
                        <div class="form-label-group">
                            <asp:Label ID="usernameLbl" runat="server" Text="Username"></asp:Label>
                            <asp:TextBox ID="usernameInput" runat="server" class="form-control"></asp:TextBox>
                        </div>
                        <div class="form-label-group">
                            <asp:Label ID="passwordLbl" runat="server" Text="Password"></asp:Label>
                            <asp:TextBox TextMode="Password" ID="passwordInput" runat="server" class="form-control"></asp:TextBox>
                        </div>

                        <div class="custom-control custom-checkbox mb-3">
                            <div class="form-check">
                                <asp:CheckBox ID="RememberMeCheckbox" runat="server" class="form-check-input"/>
                                <asp:Label ID="rememberMeLbl" runat="server" Text="Remember Me" class="text-center"></asp:Label>
                            </div>
                        </div> 
                        <div class="form-label-group">
                            <asp:Label ID="registerBtnLbl" runat="server" Text="Don't have account?" class="text-center"></asp:Label>
                            <asp:Button ID="registerBtn" OnClick="registerBtn_Click" Text="Register Here" runat="server" class="btn btn-link"/> 
                        </div>
                        <br />

                        <div class="form-label-group col-md-6">
                            <asp:Button ID="loginBtn" OnClick="loginBtn_Click" Text="Login" runat="server" class="btn btn-primary btn-block text-uppercase" /> 
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
   
    <div class="form-group col-md-6">
        <asp:Label ID="labelError" runat="server" Text=""></asp:Label> 
    </div> 
</asp:Content>
