<%@ Page Title="" Language="C#" MasterPageFile="~/Views/MasterPage.Master" AutoEventWireup="true" CodeBehind="Cleaning.aspx.cs" Inherits="Jasuvis.Views.Cleaning" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
    <asp:Repeater ID="tr" runat="server" OnItemDataBound="tr_ItemDataBound">
                    <ItemTemplate>
                            <div class="tr">

                                <div class="tr-spDetail">
                                    <asp:Image ID="img" runat="server" ImageUrl='<%# Eval("serviceProviderPhoto") %>'/>
                                    <div class="tr-spProfile">

                                    <asp:Label ID="lblName" runat="server" CssClass="spName" Text='<%# Eval("serviceProviderName") %>'></asp:Label>   

                                        <asp:Label ID="lblServiceType" runat="server" Text='<%# Eval("serviceTypeName") %>'></asp:Label>
                                        <br />
                                    </div>

                                </div>
                                <div class="tr-Detail">

                                    <asp:Label ID="Label1" runat="server" CssClass="spName" Text='<%# Eval("transactionDate") %>'></asp:Label>   

                                        <br />
                                    </div>

                                </div>
                            </div>
                        <hr id="tr-hr" />
                    </ItemTemplate>
        </asp:Repeater>
</asp:Content>