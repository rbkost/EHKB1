<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="SearchResults.aspx.cs" Inherits="SiteDraft1.WebForm3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="StyleSheet1.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Image ID="EHITKBLogo" runat="server" Height="69px" ImageAlign="Middle" ImageUrl="~/Images/ehkblogo_it.png"  Width="231px" />
    <asp:TextBox ID="SearchBox" runat="server" Height="23px" Width="236px"></asp:TextBox> &nbsp;
    <asp:Button ID="SearchButton" runat="server" Height="23px" Text="Search" Width="108px" OnClick="SearchButton_Click" />
    &nbsp <asp:Label ID="ErrorLbl" runat="server" ForeColor="Red" Text="" Height="23px" Width="238px"></asp:Label>

    <hr />
    <asp:Label ID="Label1" runat="server" Text="Search Results: "></asp:Label>
    <asp:Label ID="ReturnCount" runat="server" Text="0"></asp:Label>
    <hr />
    
</asp:Content>
