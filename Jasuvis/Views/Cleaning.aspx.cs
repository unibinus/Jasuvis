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
    public partial class Cleaning : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            User u = (User)Session["UserLoggedin"];
            if (u==null)
            {
                Response.Redirect("~/Views/LoginPage.aspx");
            }
            else
            {
                ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
                Controllers.SPController.serviceTransaction(u, tr);
            }

        }
        protected void tr_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {

            }
        }

        protected void AccBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string type = btn.CommandArgument;
            List<Transaction> transactions = Handlers.TransactionHandler.getTR();
            foreach (RepeaterItem item in tr.Items)
            {
                for (int i = 0; i < transactions.Count; i++)
                {
                    if (transactions[i].TransactionID == type)
                    {
                        Button button = (Button)item.FindControl("Accept");
                        Button button1 = (Button)item.FindControl("Decline");
                        button.Visible = false;
                        button1.Visible = false;

                    }

                }
            }
        }

        protected void DeclineBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string type = btn.CommandArgument;
        }
    }
}