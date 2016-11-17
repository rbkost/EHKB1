<%@ Page Title="Excela Health Knowledge Base" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="main.aspx.cs" Inherits="SiteDraft1.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
        <asp:Image ID="Image1" runat="server" Height="250px" Width="800px" ImageUrl="~/Images/ehkblogo_it.png" ImageAlign="Baseline" /> <br />
        <br />
    <asp:TextBox ID="SearchBox" runat="server" Width="500px" Height="25px" Font-Size="Medium" Wrap="False"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Search1" runat="server" Text="Search" Width="200px" Height="33px" Font-Size="X-Large" OnClick="Search1_Click" />
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="Advanced1" runat="server" Text="Advanced" Width="200px" Height="33px" Font-Size="X-Large"  />
        <br /><br />
        <asp:Label ID="ErrorLbl" runat="server" Font-Bold="True" ForeColor="#CC0000"></asp:Label>
        <br />
    </center>
</asp:Content>
