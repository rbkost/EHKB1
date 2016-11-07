<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="AdvanceSearch.aspx.cs" Inherits="SiteDraft1.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <center>
    <asp:Image ID="Image1" runat="server" Height="250px" ImageUrl="~/Images/ehkblogo_it.png" Width="800px" />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Advanced Search" Font-Size="XX-Large"></asp:Label>
        
    </center>
    <hr />
    <asp:Panel ID="Panel1" runat="server" Height="435px" Width="220px" HorizontalAlign="Center" style="display:inline-block" BorderColor="Black" ForeColor="Black">
        <asp:Label ID="Label2" runat="server" Text="Limit Results by Date" Font-Bold="True"></asp:Label><br />
        <asp:Calendar ID="CalFrom" runat="server" Height="100px" Width="100px" OnSelectionChanged="CalFrom_SelectionChanged"></asp:Calendar>
        
        <asp:Calendar ID="CalTo" runat="server" Height="100px" Width="100px" OnSelectionChanged="CalTo_SelectionChanged"></asp:Calendar>
        <asp:Label ID="LBLFrom" runat="server" Text="FROM:"></asp:Label>
        <asp:Label ID="DateDisplayFrom" runat="server"></asp:Label><br />
        <asp:Label ID="LBLTo" runat="server" Text="TO:"></asp:Label>
        <asp:Label ID="DateDisplayTo" runat="server"></asp:Label>
    </asp:Panel>

  <asp:Panel ID="Panel2" runat="server" Height="435px" Width="220px" HorizontalAlign="Center" style="display:inline-block" BorderColor="Black" ForeColor="Black">
        <asp:Label ID="Label3" runat="server" Text="Limit Results by Application" Font-Bold="True"></asp:Label><br />
      <br />

      <asp:DropDownList ID="DropDownList1" runat="server" Height="46px" Width="178px"></asp:DropDownList>
    </asp:Panel>
    

</asp:Content>
