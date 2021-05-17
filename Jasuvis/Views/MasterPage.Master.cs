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

        }


        protected void JasuvisLogo_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/Views/HomePage.aspx");
        }

        protected void searchButton_Click(object sender, EventArgs e)
        {

        }
    }
}