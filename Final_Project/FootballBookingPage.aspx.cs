using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Final_Project.ServiceReference1;

namespace Final_Project
{
    public partial class FootballBookingPage : System.Web.UI.Page
    {
        Service1Client client = new Service1Client(); 
       
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            client.setLeague(LeagueDropDownList.SelectedValue);
            client.setTimeFrame(TimeFrameBox.Text);
            string s = client.ReturnMatches();
            //Output1.Text = s;
            string[] answer = s.Split('@');
            foreach(string str in answer)
            {
                ListBox1.Items.Add(str);
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Output2.Text =  client.GetTeamInfo(TextBox1.Text,TimeBox2.Text);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int num = Session.Count + 1;
            string key = "ticket" + num.ToString();
            string[] ticket = ListBox1.SelectedValue.Split('|');
            TicketInfo Order = new TicketInfo(ticket[0], ticket[1], ticket[2],true);
            Session[key] = Order;
            Response.Redirect("Default.aspx");
        }
    }
}