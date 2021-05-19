<%@ Page Title="" Language="C#" MasterPageFile="~/Views/MasterPage.Master" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="Jasuvis.Views.RegisterPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-sm-9 col-md-7 col-lg-5 mx-auto">
                <div class="card card-signin my-5">
                    <div class="card-body">
                        <div class="regis">
                            Register
                        </div>
                        <%-- PAge 1 --%>
                        <div class="form-label-group">
                            <asp:Label ID="usernameLbl" runat="server" Text="Username"></asp:Label>
                            <asp:TextBox ID="usernameTxt" runat="server" class="form-control"></asp:TextBox>
                        </div>
                        <div class="form-label-group">
                            <asp:Label ClientIDMode="Static" ID="emailLbl" runat="server" Text="Email"></asp:Label>
                            <asp:TextBox ID="emailTxt" runat="server" class="form-control"></asp:TextBox>
                        </div>
                        <div class="form-label-group">
                            <asp:Label ClientIDMode="Static" ID="passwordLbl" runat="server" Text="Password"></asp:Label>
                            <asp:TextBox ID="passwordTxt" TextMode="Password" runat="server"  class="form-control"></asp:TextBox>
                        </div>
                        <div class="form-label-group">
                            <asp:Label ClientIDMode="Static" ID="nameLbl" runat="server" Text="Name"></asp:Label>
                            <asp:TextBox ID="nameTxt" runat="server"  class="form-control"></asp:TextBox>
                        </div>
                        <div class="form-label-group">
                            <asp:Label ClientIDMode="Static" ID="phoneLbl" runat="server" Text="Phone Number"></asp:Label>
                            <asp:TextBox ID="phoneTxt" runat="server" class="form-control"></asp:TextBox>
                        </div>
                        <div>
                            <asp:Label ID="genderLbl" runat="server" Text="Gender"></asp:Label>
                            <asp:DropDownList ID="genderDDL" runat="server">
                                 <asp:ListItem Value="null">Select Gender</asp:ListItem>
                                 <asp:ListItem Value="M">Male</asp:ListItem>
                                 <asp:ListItem Value="F">Female</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <br />
                        <div class="form-label-group">
                            <asp:Label ID="addressLbl" runat="server" Text="Address"></asp:Label>
                            <asp:TextBox ID="addressTxt" TextMode="MultiLine" runat="server"  class="form-control"></asp:TextBox>
                        </div>
                        <div class="form-label-group">
                            <asp:Label ID="serviceProviderConfirmationLabel" runat="server" Text="I want to be a service provider"></asp:Label>
                                <asp:RadioButtonList CssClass="radioClass" ID="serviceProviderRadioBtn" RepeatDirection="Vertical" runat="server"  class="form-control">
                                     <asp:ListItem Value="Yes">Yes</asp:ListItem>
                                     <asp:ListItem Value="No">No</asp:ListItem>
                                </asp:RadioButtonList>
                            <%--<asp:Label ID="errorRadioServiceProvider" runat="server" Text="EROROOROROOR"></asp:Label>--%>
                        </div>

                        <div class="form-label-group">
                            <asp:Label ID="userTermsAndConditionLbl" runat="server" Text="I agree to the terms and condition"></asp:Label>
                            <asp:CheckBox ID="userTermsAndConditionCheckBox" runat="server" class="form-control"/>
                        </div>
                        <%-- Page1 --%>
                        <%-- Page2 --%>

                        <div class="form-label-group">
                            <asp:Label ID="uploadKTP" runat="server" Text="Upload your KTP"></asp:Label>
                            <asp:FileUpload ID="KTPUpload" runat="server" class="form-control"/>
                        </div>
                        <div class="form-label-group">
                            <asp:Label ID="uploadSelfieWithKTP" runat="server" Text="Upload your selfie with KTP"></asp:Label>
                            <asp:FileUpload ID="selfieKTPUpload" runat="server" class="form-control"/>
                        </div>
                        <div class="form-label-group">
                            <asp:Label ID="uploadPictureLabel" runat="server" Text="Upload your profile picture" ></asp:Label>
                            <asp:FileUpload ID="profilePictureFile" runat="server" class="form-control"/>
                        </div>
                        <div class="form-label-group">
                            <asp:Label ID="uploadPictureExtensionLbl" runat="server" Text="* Allowed file extensions: 'jpg', 'png', 'jpeg'"></asp:Label>
                            <asp:Label ID="uploadPictureMaxSizeLbl" runat="server" Text="Maximum file size is 4MB" ></asp:Label>
                        </div>
                        <%-- Page2 --%>
                        <%-- PAge3 --%>
                        <div class="form-label-group">
                            <asp:Label ID="serviceNameLbl" runat="server" Text="Service Name"></asp:Label>
                            <asp:TextBox ID="serviceNameTxt" runat="server" class="form-control"></asp:TextBox>
                        </div>
                        <div class="form-label-group">
                            <asp:Label ID="serviceTypeDDLLabel" runat="server" Text="Service Type"></asp:Label>
                            <asp:DropDownList ID="serviceTypeDDL" runat="server" class="form-control">
                                 <asp:ListItem Value=""></asp:ListItem>
                                 <asp:ListItem Value="M"></asp:ListItem>
                                 <asp:ListItem Value="F"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="form-label-group">
                            <asp:Label ID="serviceDescriptionLbl" runat="server" Text="Description your service (What you do)"></asp:Label>
                            <asp:TextBox ID="serviceDescriptionTxt" TextMode="MultiLine" runat="server" class="form-control"></asp:TextBox>
                        </div>
                        <div class="form-label-group">
                            <asp:Label ID="servicePriceLbl" runat="server" Text="Input your service price"></asp:Label>
                            <asp:TextBox ID="servicePriceTxt" runat="server" class="form-control"></asp:TextBox>
                        </div>
                        <div class="form-label-group">
                            <asp:Label ID="serviceProviderTermsAndConditionLbl" runat="server" Text="I agree with the terms and condition of being a service provider"></asp:Label>
                            <asp:CheckBox ID="serviceProviderTermsAndConditionCheckBox" runat="server" class="form-control"/>
                        </div>

                        <%-- PAge3 --%>
                        <div class="form-label-group">
                            <asp:Label ID="errorLbl" runat="server" ForeColor="Red" Text=""></asp:Label>
                        </div>
                        <asp:Button ID="RegisterBtn" OnClick="RegisterBtn_Click" runat="server" Text="Register"/>
                    </div>
                 </div>
            </div>
        </div>
    </div>
    
    <script type="text/javascript">
        $(document).ready(function () {


                        $.validator.addMethod("GenderDDLValidation", function (value, element, param) {
                            if (value == "null")
                                return false;
                            else
                                return true;
                        }, "Please select a Gender.");
                        $.validator.addMethod("AddressValidation", function (value, element) {
                            if (!value.startsWith("Jl. ")) {
                                return false;
                            }
                            else {
                                return true;
                            }
                        }, "Address must start with Jl. ");
                        $.validator.addMethod("fileSizeValidation", function (value, element, param) {
                            return this.optional(element) || (element.files[0].size <= param);
                        }, "Maximum file size is 4MB.");
                        $.validator.addMethod("minimumPrice", function (value, element, param) {
                            return value > param;
                        }, "Minimum Price is 0");
                        $("#form1").validate({
                            rules: {
                        <%=usernameTxt.UniqueID %>: {
                            required: true,
                        },
                        <%=emailTxt.UniqueID %>: {
                                required: true,
                                email: true
                            },
                        <%=passwordTxt.UniqueID %>: {
                                required: true,
                                minlength: 8
                            },
                        <%=nameTxt.UniqueID %>: {
                                required: true
                            },
                        <%=phoneTxt.UniqueID %>: {
                                required: true,
                                number: true,
                            },
                        <%=genderDDL.UniqueID %>: {
                                GenderDDLValidation: true
                            },
                        <%=addressTxt.UniqueID %>: {
                                required: true,
                                AddressValidation: true
                            },
                        <%=serviceProviderRadioBtn.UniqueID%>: {
                                required: true
                            },
                        <%=userTermsAndConditionCheckBox.UniqueID %>: {
                                required: true
                            },
                        <%=KTPUpload.UniqueID%>: {
                                required: true,
                                extension: "png|jpe?g|png",
                                fileSizeValidation: 4194304
                            },
                        <%=selfieKTPUpload.UniqueID%>: {
                                required: true,
                                extension: "png|jpeg|jpg|png",
                                fileSizeValidation: 4194304
                            },
                        <%=profilePictureFile.UniqueID%>: {
                                required: true,
                                extension: "png|jpeg|jpg|png",
                                fileSizeValidation: 4194304
                            },
                        <%=serviceNameTxt.UniqueID%>: {
                                required: true
                            },
                        <%=servicePriceTxt.UniqueID%>: {
                                required: true,
                                minimumPrice: 0 + Number.MIN_VALUE
                            },
                        <%=serviceDescriptionTxt.UniqueID%>: {
                                required: true
                            },
                        <%=serviceProviderTermsAndConditionCheckBox.UniqueID%>: {
                                required: true
                            },
                    },
                    messages: {
                        <%=usernameTxt.UniqueID %>: {
                            required: "Please enter a username"
                        },
                        <%=emailTxt.UniqueID %>: {
                            required: "Please enter your email",
                            email: "Invalid email format"
                        },
                        <%=passwordTxt.UniqueID %>: {
                            required: "Please enter a password",
                            minlength: "password must be minimal 8 characters"
                        },
                        <%=nameTxt.UniqueID %>: {
                            required: "Please enter your name",
                        },
                        <%=phoneTxt.UniqueID %>: {
                            required: "Please enter your phone number",
                            number: "Please enter your phone number as a numerical value"
                        },
                        <%=addressTxt.UniqueID %>: {
                            required: "Please enter your home address"
                        },
                       <%=serviceProviderRadioBtn.UniqueID %>: {
                            required: "Please choose whether you are a service provider or not"
                        },
                       <%=userTermsAndConditionCheckBox.UniqueID %>: {
                            required: "You have to agree to the terms and condition"

                        },
                        <%=KTPUpload.UniqueID%>: {
                            required: "Please upload your KTP photo",
                            extension: "File extension must be either 'jpg', 'png', 'jpeg'"
                        },
                        <%=selfieKTPUpload.UniqueID%>: {
                            required: "Please upload your selfie with KTP",
                            extension: "File extension must be either 'jpg', 'png', 'jpeg'"
                        },
                        <%=profilePictureFile.UniqueID%>: {
                            required: "Please upload your profile photo",
                            extension: "File extension must be either 'jpg', 'png', 'jpeg'"
                        },
                        <%=servicePriceTxt.UniqueID%>: {
                            required: "Please input your service price"
                        },
                        <%=serviceDescriptionTxt.UniqueID%>: {
                            required: "Please provide a description for your service"
                        },
                        <%=serviceProviderTermsAndConditionCheckBox.UniqueID%>: {
                            required: "You have to agree to the terms and condition"
                        },
                    },
                    errorPlacement: function (error, element) {
                        if (element.is(":radio")) {
                            error.appendTo(element.parents('.radioClass'));
                        }
                        else { // This is the default behavior   
                            error.insertAfter(element);
                        }
                    }

                });
});


    </script>
</asp:Content>
