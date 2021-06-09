<%@ Page Title="" Language="C#" MasterPageFile="~/Views/MasterPage.Master" AutoEventWireup="true" CodeBehind="Cleaning.aspx.cs" Inherits="Jasuvis.Views.Cleaning" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Repeater ID="tr" runat="server" OnItemDataBound="tr_ItemDataBound">
                    <ItemTemplate>
                            <div class="sp">

                                <div class="spDetail">
                                    <asp:Image ID="img" runat="server" ImageUrl='<%# Eval("serviceProviderPhoto") %>'/>
                                    <div class="spProfile">

                                    <%--<p>Name: </p>--%>
                                    <asp:Label ID="lblName" runat="server" CssClass="spName" Text='<%# Eval("serviceProviderName") %>'></asp:Label>   

                                    <%--<p>Service Type: </p>--%>
                                        <asp:Label ID="lblServiceType" runat="server" Text='<%# Eval("serviceTypeName") %>'></asp:Label>
                                        <br />
                                    </div>
                                    <div class="spDesc"> 

                                        <p>Service Name: </p>
                                        <asp:Label ID="lblServiceName" runat="server" Text='<%# Eval("servicename") %>'></asp:Label>
                                        <br />

                                
                                        <p>Service Description: </p>
                                        <asp:Label ID="lblServiceDescription" runat="server" Text='<%# Eval("serviceDescription") %>'></asp:Label>
                                    </div>
                                </div>

                            </div>
                    </ItemTemplate>
        </asp:Repeater>
</asp:Content>
