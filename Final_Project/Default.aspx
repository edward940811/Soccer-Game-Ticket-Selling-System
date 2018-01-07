<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Final_Project.Default" %>
<%@ Register TagPrefix = "cse" TagName="semester" src="~/WebUserControl1.ascx" %>
<%@ Register TagPrefix="user" TagName="LoginControl" src="~/LoginControl.ascx" %>
<%@ Register TagPrefix = "sc" TagName="shoppingcart" src="~/ShoppingCart.ascx" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            Public Page&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Today&#39;s date is :
            <asp:Label id="Form2" runat = "server">
			    <cse:semester runat = "server" />
		    </asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
        <div>
            <br />
            <asp:Label ID="UserID" runat="server"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Login" />&nbsp;&nbsp;
            <asp:Button ID="News" runat="server" OnClick="News_Click" Text="FootballNews" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Signout" runat="server" OnClick="Signout_Click" Text="Signout" />
            <br />
            &nbsp;<br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Staff" style="height: 26px" />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="BuyTickets" />
            <br />
            <br />
            <br />
            <br />
            <div>
                <sc:shoppingcart runat="server"/>
            </div>
        </div>
    </form>
</body>
</html>
