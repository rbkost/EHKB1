using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiteDraft1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        public string DateTo;
        public string DateFrom;

        protected void Page_Load(object sender, EventArgs e)
        {
          //  CalFrom.SelectedDate = DateTime.Now;
          //  CalTo.SelectedDate = DateTime.Now;
        }

        protected void CalTo_SelectionChanged(object sender, EventArgs e)
        {
            DateTo = CalTo.SelectedDate.ToString();
            DateDisplayTo.Text = DateTo;
        }

        protected void CalFrom_SelectionChanged(object sender, EventArgs e)
        {
            DateFrom = CalFrom.SelectedDate.ToString();
            DateDisplayFrom.Text = DateFrom;
        }

       
    }
}