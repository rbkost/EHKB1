using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiteDraft1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Search1_Click(object sender, EventArgs e)
        {
            string Data = SearchBox.Text;

            ErrorLbl.Text = Data;

            if(string.IsNullOrEmpty(Data))
            {
                //see if SearchBox is blank, if it is blank, prompt user that data is needed or do nothing.
                DisplayError();
               
            }
            else
            {
                //Send to Search page with Data Information
                Server.Transfer("SearchResults.aspx?request=" + Data , true);
            }
           

    
            
            
        }

       private void DisplayError()
        {

            ErrorLbl.Text = "Search field can not be empty!";

        }
    }
}