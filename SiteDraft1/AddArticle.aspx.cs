using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using CKEditor;
using System.IO;

namespace SiteDraft1
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CKEditor1.FilebrowserImageUploadUrl = "Upload.ashx";
            CKEditor1.ResizeEnabled = false;
            CKEditor1.config.toolbar = "Basic";
            CKEditor1.config.image_previewText = " ";
            CKEditor1.config.htmlEncodeOutput = true;
            // CKEditor1.config.filebrowserImageBrowseLinkUrl = " ";

        }



        public void PreviewPage()
        {
            string Name = ArticleName.Text;
            string Descrip = DescTxtBox.Text;
            string Tags = TagsBox.Text;
            string body = CKEditor1.Text;
            
        
            body = HttpUtility.UrlEncode(body);

            System.Diagnostics.Debug.WriteLine(body);
            System.Diagnostics.Debug.WriteLine("-----------------");
           
            // Console.WriteLine(body);
            Server.Transfer("ArticleConfirmation.aspx?name=" + Name + "&descrip=" + Descrip + "&body=" + body + "&tags=" + Tags, false);
            
        }

        protected void Next_Click(object sender, EventArgs e)
        {
            PreviewPage();
        }

        protected void Cancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddArticle.aspx" );
        }
    }

    
}