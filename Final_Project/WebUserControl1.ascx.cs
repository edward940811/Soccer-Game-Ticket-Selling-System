using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final_Project
{
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String semester, year;
            Int32 m = DateTime.Now.Month;
            Int32 d = DateTime.Now.Day;
            if (m <= 5) semester = "Spring";
            else if (m <= 7) semester = "Summer";
            else semester = "Fall";
            Name.Text = Context.User.Identity.Name;

            Int32 yr = DateTime.Now.Year;
            year = yr.ToString();
            lblSemester.Text = semester;
            lblYear.Text = year;
            Date.Text = m.ToString() +"/"+ d.ToString();
        }
    }
}