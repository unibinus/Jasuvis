using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Jasuvis.Views
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserLoggedin"] != null)
            {
                TransactionLink.Visible = true;
                loginLink.Text = string.Format("Logout");
            }
            else
            {
                TransactionLink.Visible = false;
            }
        }


        protected void JasuvisLogo_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/Views/HomePage.aspx");
        }

        protected void searchButton_Click(object sender, EventArgs e)
        {

        }

        protected void loginLink_Command(object sender, CommandEventArgs e)
        {
            if (loginLink.Text == "Logout")
            {
                Session["UserLoggedin"] = null;
                Session.Clear();
                Session.Abandon();
                loginLink.Text = string.Format("Login");
                Response.Redirect("~/Views/HomePage.aspx");
            }
            else
            {
                Response.Redirect("~/Views/LoginPage.aspx");
            }
        }
    }
}