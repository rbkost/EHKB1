using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace SiteDraft1
{
    public partial class ArticleConfirmation : System.Web.UI.Page
    {
        String Title;
        String Description;
        String Body;
        String Tags;

        static string PrevPage;

        protected void Page_Load(object sender, EventArgs e)
        {
            Title = Request.QueryString["name"];
            Description = Request.QueryString["descrip"];
            Body = Request.QueryString["body"];
            Tags = Request.QueryString["tags"];
            Body = Body.Replace("%26", "&amp;");
           

            
            System.Diagnostics.Debug.WriteLine(Body);
            System.Diagnostics.Debug.WriteLine("-----------------");
            TitleLbl.Text = Title;
            Descriplbl.Text = Description;
            // Bodylbl.Text = Body;
           
          
            htmlpage.InnerHtml = Body;
            

            Tagslbl.Text = Tags;

            PrevPage = Request.UrlReferrer.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Send to Server

            //Datalinq to SQL database using DataLinq.dbml
            DataLinqDataContext db = new DataLinqDataContext();
            Table<EHKB> ehKB = db.GetTable<EHKB>();

            EHKB Row = new EHKB {
                Summary = Title,
                LongDescription = Description,
                Tags = Tags,
                Body = Body,
                DataAdded = System.DateTime.Now.ToString()
                
            };

            db.EHKBs.InsertOnSubmit(Row);

            try
            {
                db.SubmitChanges();
            } catch (Exception q)
            {
                //something went wrong
            }

            //go to page that was made

            int PageID = Row.id;

            OpenNewWindow("test.aspx");

           // Response.Redirect("PageLoad.aspx?request=" + PageID.ToString());

        }

        public void OpenNewWindow(string url)

        {

            ClientScript.RegisterStartupScript(this.GetType(), "newWindow", String.Format("<script>window.open('{0}');</script>", url));

        }


    }
}