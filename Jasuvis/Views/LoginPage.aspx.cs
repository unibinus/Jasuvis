using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Jasuvis.Controllers;

namespace Jasuvis.Views
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                emailTxt.Text = AuthenticationController.getEmailFromCookie(Request);
                passwordTxt.Attributes.Add("value", AuthenticationController.getPasswordFromCookie(Request));

            }
        }


        protected void loginBtn_Click(object sender, EventArgs e)
        {
            String email = emailTxt.Text;
            String password = passwordTxt.Text;
            Boolean rememberMeChecked = rememberMeChk.Checked;
            errorLbl.Text = Controllers.AuthenticationController.userLoginAuthentication(email, password,rememberMeChecked,Session,Response);
        }
    }
}