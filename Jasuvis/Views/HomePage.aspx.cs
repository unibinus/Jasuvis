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
            List < ServiceType > listST= UserRepository.GetServiceTypes();
            Repeater.DataSource = listST;
            Repeater.DataBind();
        }

        protected void spRegisBtn_Click(object sender, EventArgs e)
        {

        }
    }
}