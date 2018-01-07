<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LoginControl.ascx.cs" Inherits="Final_Project.LoginControl" %>
<asp:Panel ID="Panel1" runat="server" Height="120px" Width="277px">
    Username:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="username" runat="server" OnTextChanged="username_TextChanged"></asp:TextBox>
    <br />
    <br />
    Password:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="Password" TextMode="Password" runat="server"></asp:TextBox>
    <br />
    <br />
    &nbsp;&nbsp;<asp:CheckBox ID="CheckBox1" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" Text="Remember me" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Submit" runat="server" Text="Submit" OnClick="Submit_Click" />
</asp:Panel>

<br />

<asp:Label ID="UserID" runat="server" Text="Label"></asp:Label>


