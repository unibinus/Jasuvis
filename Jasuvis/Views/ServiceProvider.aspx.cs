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
        string time;
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
                ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
                Controllers.SPController.serviceProviderData(u,rep);
                //Calendar calendar = ((Calendar)rep.Items[24].FindControl("Calendar1"));

                //calendar.StartDate = DateTime.Now;
                //string a = ((Label) rep.FindControl("lblName")).Text;
                //Console.WriteLine(a);
                //Calendar1.StartDate = DateTime.Now;
            }
        }
        protected void BookBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string type = btn.CommandArgument;
            time = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss tt");
            //types = btn.CommandArgument;
            //Controllers.ExploreController.ProviderTypeData(spData, type);
            Response.Redirect("~/Views/ExplorePage.aspx");
            //ScriptManager.RegisterStartupScript(Page, typeof(Page), "Popup", "alert('This is alert Message from C#')", true);
        }
        protected void AppointmentBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string type = btn.CommandArgument;
            time = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss tt");
            //types = btn.CommandArgument;
            //Controllers.ExploreController.ProviderTypeData(spData, type);
            //rep.DataSource = Table;
            rep.DataBind();

            //Loop through repeater items
            foreach (RepeaterItem item in rep.Items)
            {
                //Access the button control
                TextBox textBox = item.FindControl("txtSessionTime") as TextBox;
                TextBox textBox1 = item.FindControl("txtDOB") as TextBox;
                if (textBox == null)
                {
                    textBox.Visible = true;
                    
                    //set the control value here.
                }
                else if(textBox1 == null){
                    textBox1.Visible = true;
                }
                else { 
                    Response.Redirect("~/Views/ExplorePage.aspx"); 
                }
            }
            
        }

        protected void rep_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            //Calendar calendar = (Calendar)rep.Items[e.Item.ItemIndex].FindControl("Calendar1");
            //calendar.StartdDate = 
        }

        protected void calendar1_SelectionChanged(object sender, EventArgs e)
        {
            //string date = "You Selected: " + Calendar1.SelectedDate.ToString("D");
        }

        protected void rep_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                //Access the button control
                //Calendar calendar = (Calendar)e.Item.FindControl("Calendar1");
                AjaxControlToolkit.CalendarExtender calendar1 = (AjaxControlToolkit.CalendarExtender)e.Item.FindControl("Calendar1");
                calendar1.StartDate = DateTime.Now;
            }
        }
    }
}