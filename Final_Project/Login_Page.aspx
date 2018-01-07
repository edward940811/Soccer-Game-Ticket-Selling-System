<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login_Page.aspx.cs" Inherits="Final_Project.Login_Page" %>
<%@ Register TagPrefix="user" TagName="LoginControl" src="~/LoginControl.ascx" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
      <asp:Label runat = "server">
	       <user:LoginControl runat="server"></user:LoginControl>
      </asp:Label>
    </form>
</body>
</html>
