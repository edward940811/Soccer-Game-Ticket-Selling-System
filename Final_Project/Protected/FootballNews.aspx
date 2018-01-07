<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FootballNews.aspx.cs" Inherits="Final_Project.FootballNews" %>
<%@ Register TagPrefix = "sc" TagName="shoppingcart" src="~/ShoppingCart.ascx" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            returns only the news related to soccer for now, choosing from the 10 responses returned by service.<br />
            sortby function depends on service<br />
            channel&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; available sort<br />
            bbc&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; NULL,top&nbsp;&nbsp; ****latest is not 
            available for bbc!!!!<br />
            fox-sport&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; NULL,top , latest<br />
            sports bib&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; NULL,top , latest<br />
            <br />
            output returns URL &quot;|&quot; TITLE&nbsp; ending with @<br />
            if todays news doesn&#39;t have soccer related news it returns empty string<br />
            <br />
            string makerequest()&nbsp;&nbsp;&nbsp; return the output<br />
            void setsortby(string sort)&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; set the sortby in url /sortBy=xxx<br />
            void setnewschannel(string channel) set the news channel bbc,fox,sports-bible<br />
            string returnsearchedurl() return searchedurl<br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Choose news channel"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="Dropdownchannel" runat="server" OnSelectedIndexChanged="Dropdownchannel_SelectedIndexChanged">
                <asp:ListItem>bbc</asp:ListItem>
                <asp:ListItem>fox</asp:ListItem>
                <asp:ListItem Value="sbb">sports bible</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            Sortby&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="Dropdowncategory" runat="server">
                <asp:ListItem>NULL</asp:ListItem>
                <asp:ListItem>top</asp:ListItem>
                <asp:ListItem>latest</asp:ListItem>
            </asp:DropDownList>
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <asp:Label ID="Output" runat="server" Text="output"></asp:Label>
            <br />
            <br />
            <asp:Label ID="searchedurl" runat="server" Text="searchurl"></asp:Label>
            <br />
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <br />
        <br />
        <div>
        </div>
    </form>
</body>
</html>
