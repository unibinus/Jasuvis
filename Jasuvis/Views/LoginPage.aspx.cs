﻿using System;
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
                emailInput.Text = AuthenticationController.getEmailFromCookie(Request);
                passwordInput.Attributes.Add("value", AuthenticationController.getPasswordFromCookie(Request));

            }
        }


        protected void loginBtn_Click(object sender, EventArgs e)
        {
            String email = emailInput.Text;
            String password = passwordInput.Text;
            Boolean rememberMeChecked = RememberMeCheckbox.Checked;
            labelError.Text = Controllers.AuthenticationController.userLoginAuthentication(email, password, rememberMeChecked, Session, Response);
        }
    }
}