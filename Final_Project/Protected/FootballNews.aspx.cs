using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Final_Project.ServiceReference3;

namespace Final_Project
{
    public partial class FootballNews : System.Web.UI.Page
    {
        Final_Project.ServiceReference3.Service1Client client3 = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //if (displaynum.Text != client.ReturnSearchedUrl()) 
              //  client.SetDisplayNumber(displaynum.Text);

            client3.SetNewsChannel(Dropdownchannel.SelectedValue);
            if (Dropdowncategory.SelectedValue != "NULL")
                client3.SetSortby(Dropdowncategory.SelectedValue);
            Output.Text = client3.MakeRequest();
            searchedurl.Text = client3.ReturnSearchedUrl();
        }

        protected void displaynum_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Dropdownchannel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}