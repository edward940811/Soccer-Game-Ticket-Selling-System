using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Final_Project.EmailChecker;
using Final_Project.EmailServer;
namespace Final_Project
{
    public partial class Checkout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = TextBox1.Text;
            EmailChecker.Service1Client client = new EmailChecker.Service1Client();
            EmailServer.Service1Client client2 = new EmailServer.Service1Client();
            ListBox q = (ListBox)here.FindControl("ListBox1");
            client.setemail(s);
            if (client.Check() == true)
            {
                string ans = "";
                Label1.Text = "email sent!";
                foreach (var item in q.Items)
                {
                    ans += item.ToString();
                }
                client2.sendmail(s,"Footballticket",ans,"");
            }
            else
                Label1.Text = "please enter valid email address";
        }
    }
}