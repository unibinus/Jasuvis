using Jasuvis.Models;
using Jasuvis.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;

namespace Jasuvis.Views
{
    public partial class DetailServiceProvider : System.Web.UI.Page
    {
        static User u;
        DateTime time;
        static User us;
        protected void Page_Load(object sender, EventArgs e)

        {
            us = (User) Session["UserLoggedin"];
            string id = Request.QueryString["id"];
            u = UserRepository.getUserById(id);

            if (u == null)
            {
                Response.Redirect("~/Views/ErrorPage.aspx");
            }
            else
            {
                ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
                Controllers.SPController.serviceProviderData(u, rep);
            }
        }
        protected void BookBtn_Click(object sender, EventArgs e)
        {
            if (Session["UserLoggedin"] != null)
            {
                Button btn = (Button)sender;
                string type = btn.CommandArgument;
                time = DateTime.Now;
                Service service = Handlers.ServiceHandler.GetService(u);
                Handlers.TransactionHandler.insertTransaction(us, service, time);
                Response.Redirect("~/Views/Cleaning.aspx");
            }
            else Response.Redirect("~/Views/LoginPage.aspx");
        }
        protected void AppointmentBtn_Click(object sender, EventArgs e)
        {
            if (Session["UserLoggedin"] != null)
            {
                Button btn = (Button)sender;
                string type = btn.CommandArgument;
                rep.DataBind();
                foreach (RepeaterItem item in rep.Items)
                {
                    TextBox textBox = item.FindControl("txtSessionTime") as TextBox;
                    TextBox textBox1 = item.FindControl("txtDOB") as TextBox;
                    AjaxControlToolkit.CalendarExtender calendar1 = (AjaxControlToolkit.CalendarExtender)item.FindControl("Calendar1");
                    textBox1.Text = calendar1.SelectedDate.ToString();
                    string x = textBox1.Text + " " + textBox.Text;
                    DateTime times = DateTime.Now;
                    Service service = Handlers.ServiceHandler.GetService(u);
                    Handlers.TransactionHandler.insertTransaction(us, service, times);

                    if (textBox == null)
                    {
                        textBox.Visible = true;

                    }
                    else if (textBox1 == null)
                    {
                        textBox1.Visible = true;
                    }
                    else
                    {
                        Response.Redirect("~/Views/Cleaning.aspx");
                    }
                }
            }
            else Response.Redirect("~/Views/LoginPage.aspx");





        }
        protected void rep_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                AjaxControlToolkit.CalendarExtender calendar1 = (AjaxControlToolkit.CalendarExtender)e.Item.FindControl("Calendar1");
                calendar1.StartDate = DateTime.Now;
            }
        }
    }
}