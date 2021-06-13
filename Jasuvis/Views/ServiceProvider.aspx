<%@ Page Title="" Language="C#" MasterPageFile="~/Views/MasterPage.Master" AutoEventWireup="true" CodeBehind="ServiceProvider.aspx.cs" Inherits="Jasuvis.Views.DetailServiceProvider" EnableEventValidation="false" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">  
</asp:ScriptManager>    
    <script type="text/javascript">
        function checkDate(sender, args) {
            if (sender._selectedDate < new Date()) {
                sender._textbox.set_Value(sender._selectedDate.format(sender._format))
            }
        }
    </script>
    <div>
        <asp:Repeater ID="rep" runat="server" OnItemDataBound="rep_ItemDataBound">
                    <ItemTemplate>
                        <div class="wrapper">
                            <div class="sp">

                                <div class="spDetail">
                                    <asp:Image ID="img" runat="server" ImageUrl='<%# Eval("serviceProviderPhoto") %>'/>
                                    <div class="spProfile">

                                    <asp:Label ID="lblName" runat="server" CssClass="spName" Text='<%# Eval("serviceProviderName") %>'></asp:Label>   
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
                                <hr />
                                    <div class="spDetail">
                                    <div class="spRating">

                                    <p>Rating: </p>
                                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("serviceProviderName")+  " / 5.00" %>'> </asp:Label> 
                                        <br />
                                         <p>Price: </p>
                                        <asp:Label ID="Label2" runat="server" Text='<%# "Rp. " + Eval("servicePrice") +",-"%>'> </asp:Label> 
                                    </div>
                                    <div class="spReview">

                                        <p>Review: </p>
                                        <asp:Label ID="Label3" runat="server" Text='<%# Eval("servicename") %>'></asp:Label>
                                        <br />

                                
                                        <p>Service Description: </p>
                                        <asp:Label ID="Label4" runat="server" Text='<%# Eval("serviceDescription") %>'></asp:Label>
                                    </div>
                                </div>
                            </div>

                            <div class="spBtn">
                                <asp:Button ID="BookBtn" class="btn" runat="server" Text='Book Now'/>
                                <asp:Button ID="AppointmentBtn" class="btn"  runat="server" Text='Book For An Appointment' />
                            </div>
                        </div>
                        

                            <asp:ModalPopupExtender ID="mp1" runat="server" PopupControlID="Panel1" TargetControlID="BookBtn"  
    CancelControlID="btnClose" BackgroundCssClass="Background">  
</asp:ModalPopupExtender> 
                            <asp:Panel ID="Panel1" align="center" runat="server">
                                <div class="Popup">
                                    <asp:Image ID="image" runat="server" ImageUrl='<%# Eval("serviceProviderPhoto") %>' class="Popsp-image"/>
                                <br />
                                <b>
                                    <asp:Label ID="serviceNameLbl" class="sp-work" runat="server" Text='<%# Eval("ServiceName") %>'></asp:Label>
                                </b>    
                                    <asp:Label ID="serviceTypeLbl" class="sp-tname" runat="server" Text='<%# Eval("serviceTypeName") %>' ></asp:Label>
                                    <br />
                                    <b>Address:</b>
                                    <asp:Label ID="UserAddress" class="sp-tname" runat="server" Text='<%# Eval("serviceAddress") %>' ></asp:Label>
                                     <b>Price: </b>
                                        <asp:Label ID="Label5" runat="server" Text='<%# "Rp. " + Eval("servicePrice") +",-"%>'> </asp:Label>
                                 <br />
                                <asp:Button ID="Book" class="btn" Width="150px" BackColor="#ff0066"  runat="server" Text='Book'  OnClick="BookBtn_Click" 
                                      UseSubmitBehavior="true"  CausesValidation="false" CommandName="Book" CommandArgument='<%# Eval("ServiceUserID") %>'/>
                                    <br />
                                </div>
                                <div class="transparentButton">
                                    <asp:Button ID ="btnClose" Width="200px" BackColor="transparent" BorderStyle="None" ForeColor="White" runat="server" Text="X"/>
                                </div>
                            </asp:Panel>
                        <asp:ModalPopupExtender ID="mp2" runat="server" PopupControlID="Panel2" TargetControlID="AppointmentBtn"  
    CancelControlID="btnClose2" BackgroundCssClass="Background">  
</asp:ModalPopupExtender> 
                            <asp:Panel ID="Panel2" align="center" runat="server">
                                <div class="Popup">
                                    <asp:Image ID="image1" runat="server" ImageUrl='<%# Eval("serviceProviderPhoto") %>' class="Popsp-image"/>
                                <br />
                                <b>
                                    <asp:Label ID="Label6" class="sp-work" runat="server" Text='<%# Eval("ServiceName") %>'></asp:Label>
                                </b>    
                                    <asp:Label ID="Label7" class="sp-tname" runat="server" Text='<%# Eval("serviceTypeName") %>' ></asp:Label>
                                    <br />
                                    <b>Calender: <asp:RequiredFieldValidator ControlToValidate="txtDOB" Enabled="True" ID="required_validator1" runat="server" Text="*" Visible="True" ForeColor="Red" /></b>
                                    
                                    <asp:TextBox ID="txtDOB" runat="server" ReadOnly="true"></asp:TextBox>  
                                    
                    <asp:CalendarExtender ID="Calendar1" runat="server" TargetControlID="txtDOB" Format="dd/MM/yyyy" Enabled="true" OnClientDateSelectionChanged="checkDate"> </asp:CalendarExtender>
                                    <b>Time (HH:MM:00 AM/PM): <asp:RequiredFieldValidator ControlToValidate="txtSessionTime" Enabled="True" ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" Visible="True" ForeColor="Red"/></b>
                                    
                                    <asp:TextBox ID="txtSessionTime" runat="server"></asp:TextBox>
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                                        ErrorMessage="You must enter a valid time. Format: HH:MM:00 AM/PM" ControlToValidate="txtSessionTime"
                                        ValidationExpression="^(1[0-2]|0[1-9]):[0-5][0-9]:[0][0]\040(AM|am|PM|pm)$"
                                        Display="Dynamic"
                                        SetFocusOnError="true"></asp:RegularExpressionValidator>
                                    <b>Address:</b>
                                    <asp:Label ID="Label8" class="sp-tname" runat="server" Text='<%# Eval("serviceAddress") %>' ></asp:Label>
                                     <b>Price: </b>
                                        <asp:Label ID="Label9" runat="server" Text='<%# "Rp. " + Eval("servicePrice") +",-"%>'> </asp:Label>
                                 <br />
                                 <asp:Button ID="Button1" class="btn" Width="150px" BackColor="#ff0066"  runat="server" Text='Book'  OnClick="AppointmentBtn_Click" 
                                      UseSubmitBehavior="false"  CommandName="Book" CommandArgument='<%# Eval("ServiceUserID") %>'/>
                                    <br />
                                </div>
                                <div class="transparentButton">
                                    <asp:Button ID ="btnClose2" Width="200px" BackColor="transparent" BorderStyle="None" ForeColor="White" runat="server" Text="X"/>
                                </div>
                            </asp:Panel>
                    </ItemTemplate>
                </asp:Repeater>
        <br />

        <br />
    </div>
</asp:Content>