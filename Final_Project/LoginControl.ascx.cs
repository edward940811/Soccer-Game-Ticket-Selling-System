using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Xml;
using System.IO;

namespace Final_Project
{
    public partial class LoginControl : System.Web.UI.UserControl
    {
        public bool MyAuthentication(string username,string password)
        {
            string fLocation = Path.Combine(Request.PhysicalApplicationPath, @"App_Data\Staff.xml");
            if (File.Exists(fLocation))
            {
                FileStream FS = new FileStream(fLocation, FileMode.Open);
                XmlDocument xd = new XmlDocument();
                xd.Load(FS);
                XmlNode node = xd.DocumentElement;
                XmlNodeList children = node.ChildNodes;
                foreach (XmlNode child in children)
                {
                    if (child.ChildNodes[0].InnerText == username)
                    {
                        if (child.ChildNodes[1].InnerText == password)
                        {
                            FS.Close();
                            return true;
                        }
                    }
                }
                FS.Close();
            }
            return false;
        }
        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            HttpCookie myCookies = new HttpCookie("myCookieId");
            myCookies["UserID"] = username.Text;
            myCookies["Password"] = Password.Text;
            myCookies.Expires = DateTime.Now.AddHours(1);
            Response.Cookies.Add(myCookies);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie myCookies = Request.Cookies["myCookieId"];
            if ((myCookies == null) || (myCookies["UserID"] == ""))
            {
                UserID.Text = "Welcome, new user";
            }
            else
            {
                UserID.Text = "Welcome, u must be " + myCookies["UserID"];
                //username.Text = myCookies["UserID"];
            }
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            if (MyAuthentication(username.Text, Password.Text))
                FormsAuthentication.RedirectFromLoginPage(username.Text, true);
            else
                UserID.Text = "Invalid Password or username";
        }

        protected void username_TextChanged(object sender, EventArgs e)
        {
           // username.Text = username.Text;
        }
    }
    
}