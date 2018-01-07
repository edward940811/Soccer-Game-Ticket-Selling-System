using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final_Project
{
    public partial class ShoppingCart : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            for (Int16 i = 1; i <= Session.Count; i++)
            {
                string indexKey = "ticket" + i;
                TicketInfo ticket = (TicketInfo)Session[indexKey];
                string s = ticket.ToString();
                if (ticket._incart == true)
                {
                    bool found = false;

                    foreach (var item in ListBox1.Items)
                    {
                        if (item.ToString().Equals(ticket._date + " " + ticket._hometeam + " against " + ticket._awayteam))
                        {
                            found = true;
                            break;
                        }
                    }
                    if (!found)
                    ListBox1.Items.Add(ticket._date +" "+ ticket._hometeam + " against "+ ticket._awayteam);
                }
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Checkout.aspx");
        }
    }
}