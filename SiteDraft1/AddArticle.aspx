
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddArticle.aspx.cs" Inherits="SiteDraft1.WebForm4" ValidateRequest ="false" %>



<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>






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
       <center> <asp:Label ID="PageTitleLbl" runat="server" Text="Add Article" Font-Size="XX-Large" Font-Bold="True" Font-Names="Arial Black"></asp:Label></center>
       <hr />
        <center>
        <asp:Panel ID="Panel1" runat="server" Height="960px" Width="80%" >
            
                <asp:Label ID="Label1" runat="server" Text="Article Name: " Font-Bold="True" Height="18px" style="vertical-align: middle" ></asp:Label>&nbsp<asp:TextBox ID="ArticleName" runat="server" Height="18px" Width="694px"></asp:TextBox><br /><br />
            
                <asp:Label ID="Description" runat="server" Text="Description: " Font-Bold="True" Height="18px" style="vertical-align: middle" ></asp:Label><asp:TextBox ID="DescTxtBox" runat="server" Height="18px" Width="721px"></asp:TextBox>
            
                <br /><br /><asp:Label runat="server" Text="Documentation" Font-Bold="True" Font-Size="X-Large"></asp:Label>
            
                <br /><br />


                  <CKEditor:CKEditorControl ID="CKEditor1" runat="server" BasePath="/ckeditor/" Height="500px" Width="80%" 
                         ToolbarBasic="|Source|Bold|Italic|Underline|NumberedList|BulletedList|Link|Unlink|-|Image|SpellChecker| / |Font|-|FontSize| / |JustifyLeft|JustifyRight|JustifyCenter|"></CKEditor:CKEditorControl>
            
                <script type="text/javascript" src="Scripts/jquery-1.4.1.min.js"></script>
                <script type="text/javascript" src="ckeditor/ckeditor.js"></script>
                <script type="text/javascript" src="ckeditor/adapters/jquery.js"></script>
                <script type="text/javascript">

                    CKEDITOR.on('dialogDefinition', function (ev) {
                        var dialogName = ev.data.name;
                        var dialogDefinition = ev.data.definition;

                        if (dialogName == 'image') {
                            dialogDefinition.removeContents('advanced');
                            dialogDefinition.removeContents('Link');
                            
                          
                        }

                        ev.data.definition.resizable = CKEDITOR.DIALOG_RESIZE_NONE;


                    });
                      


                </script>
                
            <br />
                          <asp:Label ID="Label3" runat="server" Text="Tags: " Font-Bold="True" Height="18px" style="vertical-align: top" Font-Size="X-Large" ></asp:Label><asp:TextBox ID="TagsBox" runat="server" Height="18px" Width="463px"></asp:TextBox>
                        <br /><br /><asp:Button runat="server" Text="Next" Height="68px" Width="150px" Font-Size="X-Large" ID="Next" OnClick="Next_Click"></asp:Button>
                           &nbsp&nbsp<asp:Button runat="server" Text="Cancel" Height="68px" Width="150px" Font-Size="X-Large" ID="Cancel" OnClick="Cancel_Click"></asp:Button>
                 
            </center>
        </asp:Panel>

    </div>
       
    </form>
</body>
</html>
