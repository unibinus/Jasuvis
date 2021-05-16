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
            String email = emailTxt.Text;
            String password = passwordTxt.Text;
            String name = nameTxt.Text;
            String phoneNumber = phoneTxt.Text;
            Boolean isMale = maleRadio.Checked;
            Boolean isFemale = femaleRadio.Checked;
            Boolean isServiceProvider = serviceProviderBtnYes.Checked;
            Boolean isNotServiceProvider = serviceProviderBtnNo.Checked;
            String Address = addressTxt.Text;

            errorLbl.Text = Controllers.RegisterController.registerValidation(email, password, isServiceProvider, isNotServiceProvider, name, isMale, isFemale, phoneNumber, Address, Response);
        }
    }
}