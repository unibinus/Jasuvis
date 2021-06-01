<%@ Page Title="" Language="C#" MasterPageFile="~/Views/MasterPage.Master" AutoEventWireup="true" CodeBehind="ExplorePage.aspx.cs" Inherits="Jasuvis.Views.ExplorePage" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="explore-body">
       <%-- <div class="category-menu">
            <ul class="list-group list-group-flush">
                <li class="list-group-item">
                    <asp:HyperLink ID="spCleaning" runat="server" NavigateUrl="~/Views/Cleaning.aspx">Cleaning</asp:HyperLink>
                </li>
                <li class="list-group-item">
                    Salon
                </li>
                <li class="list-group-item">
                    Barber
                </li>
                <li class="list-group-item">
                    Vehicle
                </li>
                <li class="list-group-item">
                    Others
                </li>
            </ul>
        </div>--%>
        <div class="category-menu">
                    <asp:Repeater ID="typeData" runat="server">
                        <ItemTemplate>
                            <ul class="list-group list-group-flush">
                                <li class="list-group-item">
                                    <%--<asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Views/Cleaning.aspx" Text='<%# Eval("ServiceTypeName") %>'></asp:HyperLink>--%>
                                    <asp:Button ID="CategoryBtn"  runat="server" Text='<%# Eval("ServiceTypeName") %>'  OnClick="CategoryBtn_Click" 
                                        CommandName="CategoryBtn" CommandArgument='<%# Eval("ServiceTypeName") %>'/>
                                    <%--<asp:Label ID="categorylbl" class="category-work" runat="server" Text='<%# Eval("ServiceTypeName") %>'></asp:Label>--%>
                                </li>
                            </ul>
                        </ItemTemplate>
                    </asp:Repeater>
        </div>
        <div class="home-rec">
            <div class="carousel explore-car">
                <asp:Repeater ID="spData" runat="server">
                    <ItemTemplate>
                        <asp:HyperLink ID="cardlink" runat="server" NavigateUrl='<%# "~/Views/ServiceProvider.aspx?id=" + Eval("serviceUserID") %>'>
                            <div class="card Exsp-card">
                                <asp:Image ID="image" runat="server" ImageUrl='<%# Eval("serviceProviderPhoto") %>' class="sp-image"/>
                                <asp:Label ID="serviceProviderNameLbl" class="sp-name" runat="server" Text='<%# Eval("serviceProviderName") %>' ></asp:Label>
                                <asp:Label ID="serviceNameLbl" class="sp-work" runat="server" Text='<%# Eval("ServiceName") %>'></asp:Label>
                                <asp:Label ID="serviceTypeLbl" class="sp-tname" runat="server" Text='<%# Eval("serviceTypeName") %>' ></asp:Label>
                            </div>
                         </asp:HyperLink>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    </div>
</asp:Content>
 