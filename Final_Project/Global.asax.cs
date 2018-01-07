using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Final_Project
{
    public class TicketInfo
    {
        public string _date;
        public string _hometeam;
        public string _awayteam;
        public bool _incart;
        public TicketInfo(string date, string hometeam, string awayteam, bool incart)
        {
            _date = date;
            _hometeam = hometeam;
            _awayteam = awayteam;
            _incart = incart;
        }
    }
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            Application["Title"] = "First Example";
            Application["SessionCounter"] = 0;

        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Int32 count = (Int32)Application["SessionCounter"];
            count++;
            Application["SessionCounter"] = count;
            Response.Write("Welcome! this is the "+ count +" session you have opened");
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {
            Int32 count = (Int32)Application["SessionCounter"];
            count--;
            Application["SessionCounter"] = count;
        }

        protected void Application_End(object sender, EventArgs e)
        {
            Response.Write("< hr /> This page was last accessed at " +DateTime.Now.ToString());
        }
    }
}