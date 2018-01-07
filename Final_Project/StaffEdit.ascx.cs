using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace Final_Project
{
    public partial class StaffEdit : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = "http://www.public.asu.edu/~eyang12/Staff/Staff.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(s);
            XmlNode root = doc.DocumentElement;
            XmlNode node = doc.CreateNode(XmlNodeType.Element, "Staff", "http://www.public.asu.edu/~eyang12/Staff");
            XmlNode nodeUsername = doc.CreateElement("Username");
            XmlNode nodePassword = doc.CreateElement("Password");
            nodeUsername.InnerText = TextBox1.Text;
            nodePassword.InnerText = TextBox2.Text;
            node.AppendChild(nodeUsername);
            node.AppendChild(nodePassword);
            root.AppendChild(node);
            string path = HttpContext.Current.Server.MapPath("~/App_Data/Staff.xml");
            doc.Save(path);
            Response.Redirect("../Default.aspx");
        }
    }
}