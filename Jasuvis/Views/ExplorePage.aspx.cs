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
    public partial class ExplorePage : System.Web.UI.Page
    {
        string types;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Controllers.ExploreController.ProviderTypeData(spData, types);
                //Controllers.ExploreController.serviceProviderData(spData);
                Controllers.ExploreController.serviceTypeData(typeData);
            }
            else
            {
                Controllers.ExploreController.ProviderTypeData(spData, types);
                Controllers.ExploreController.serviceTypeData(typeData);
            }
                
        }

        protected void CategoryBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string type = btn.CommandArgument;
            types = btn.CommandArgument;
            Controllers.ExploreController.ProviderTypeData(spData,type);
            //Response.Redirect("~/Views/ExplorePage.aspx");
        }
    }
}