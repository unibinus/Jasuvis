using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Jasuvis.Views
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RegisterBtn_Click(object sender, EventArgs e)
        {
            //String username = usernameTxt.Text;
            //String email = emailTxt.Text;
            //String password = passwordTxt.Text;
            //String name = nameTxt.Text;
            //String phoneNumber = phoneTxt.Text;
            //String gender = genderDDL.SelectedValue.ToString();
            //Boolean isServiceProvider = serviceProviderBtnYes.Checked;
            //Boolean isNotServiceProvider = serviceProviderBtnNo.Checked;
            //String Address = addressTxt.Text;
            //FileUpload PictureFile = profilePictureFile;
            //Boolean hasUploadedFile = profilePictureFile.HasFile;
            //errorLbl.Text = Controllers.RegisterController.registerValidation(username, email, password, isServiceProvider, isNotServiceProvider, name, gender, phoneNumber, Address, PictureFile, hasUploadedFile, Response);
            ////errorLbl.Text = Controllers.RegisterController.registerValidation(username, email, password, name, gender, phoneNumber, Address, Response);
            Response.Redirect("~/Views/HomePage.aspx");
        }
    }
}