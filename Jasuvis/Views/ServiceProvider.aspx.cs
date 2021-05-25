using Jasuvis.Models;
using Jasuvis.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Jasuvis.Views
{
    public partial class DetailServiceProvider : System.Web.UI.Page
    {
        static User u;
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];
            u = UserRepository.getUserById(id);

            if (u == null)
            {
                Response.Redirect("~/Views/ErrorPage.aspx");
            }
            else
            {
                Controllers.SPController.serviceProviderData(u);
            }
        }
    }
}