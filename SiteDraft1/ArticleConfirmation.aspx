<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ArticleConfirmation.aspx.cs" Inherits="SiteDraft1.ArticleConfirmation"  ValidateRequest ="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
         <center> <asp:Image ID="Logo" runat="server" Height="180px" ImageUrl="~/Images/ehkblogo_it.png" Width="632px" /></center>
       <br />
       <hr />
       <center> <asp:Label ID="PageTitleLbl" runat="server" Text="Article Confirmation" Font-Size="XX-Large" Font-Bold="True" Font-Names="Arial Black"></asp:Label></center>
       <hr />


    </div>
        
        <center>
        <asp:Label ID="Label2" runat="server" Text="Article Title: " Font-Bold="True"></asp:Label><asp:Label ID="TitleLbl" runat="server" Text="Label"></asp:Label><br />
        <asp:Label ID="Label3" runat="server" Text="Article Description: " Font-Bold="True"></asp:Label><asp:Label ID="Descriplbl" runat="server" Text="Label"></asp:Label><br />
        <asp:Label ID="Label4" runat="server" Text="Tags Assigned: " Font-Bold="True"></asp:Label><asp:Label ID="Tagslbl" runat="server" Text="Label"></asp:Label><br /><br />
            

        <asp:Label ID="Label1" runat="server" Text="Page Preview"></asp:Label> <br /><br />
        </center>

        <div style="margin-left:0%">

        <asp:Panel ID="Panel1" runat="server" Width="100%" BorderStyle="Solid" >
       

        <div id="htmlpage" runat="server">


        </div>
        
        </asp:Panel>
            </div>
            <br />
        <center>
        <asp:Button ID="Button1" runat="server" Text="Submit" Height="60px" Width="200px" Font-Size="Large" OnClick="Button1_Click"></asp:Button>
        </center>

    </form>
</body>
</html>
