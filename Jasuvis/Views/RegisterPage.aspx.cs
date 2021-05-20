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
            if (!Page.IsPostBack)
            {
            Controllers.RegisterController.getServiceTypeData(serviceTypeDDL);

            }
        }

        protected void RegisterBtn_Click(object sender, EventArgs e)
        {
            String username = usernameTxt.Text;
            String email = emailTxt.Text;
            String password = passwordTxt.Text;
            String name = nameTxt.Text;
            String phoneNumber = phoneTxt.Text;
            String gender = genderDDL.SelectedValue.ToString();
            String userRole = serviceProviderRadioBtn.SelectedValue.ToString();
            String Address = addressTxt.Text;
            FileUpload KTPfile = KTPUpload;
            FileUpload selfieKTPFile = selfieKTPUpload;
            FileUpload PictureFile = profilePictureFile;
            String serviceName = serviceNameTxt.Text;
            String serviceType = serviceTypeDDL.SelectedValue;
            String serviceDescription = serviceDescriptionTxt.Text;
            String servicePrice = servicePriceTxt.Text;
            errorLbl.Text = Controllers.RegisterController.registerValidation(username, email, password, name, phoneNumber, gender, userRole, Address, KTPfile, selfieKTPFile, PictureFile, serviceName, serviceType, serviceDescription, servicePrice, Response);

        }
    }
}