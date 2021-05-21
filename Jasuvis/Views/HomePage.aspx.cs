using Jasuvis.Repositories;
using Jasuvis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Jasuvis.Views
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<User> listSP = UserRepository.GetServiceProviders();
            var datasource = listSP.AsEnumerable().Take(5);
            Repeater.DataSource = datasource;
            Repeater.DataBind();
        }

        protected void RegisBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/RegisterPage.aspx");
        }
    }
}