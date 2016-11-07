using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace SiteDraft1
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        String SearchRequest;
        String[] ReceivedIDs;

        protected void Page_Load(object sender, EventArgs e)
        {
            //get the request from the previous page
            SearchRequest = Request.QueryString["request"];
            //split the words that they searched for into an array
            string[] searchwords = SearchRequest.Split(' ');

            CreateSQLConnection();

            




                            
        }

        public void CreateSQLConnection()
        {

            SqlConnection myConnection = new SqlConnection();
            myConnection.ConnectionString = "Server=tcp:ehkbtest.database.windows.net,1433;Initial Catalog=EHKBTest;Persist Security Info=False;User ID=Brian;Password=Password1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";
            myConnection.Open();

            SqlCommand command;
            SqlDataReader reader;

            string searchstring = null;

            searchstring = "SELECT Id from dbo.table WHERE Tags = 'test'";


            try
            {
                command = new SqlCommand(searchstring, myConnection);
                reader = command.ExecuteReader();

                int x = 0;

                while(reader.Read())
                {
                    ReceivedIDs[x] = reader.GetValue(x).ToString();
                    x++;
                }

                reader.Close();
                command.Dispose();
                myConnection.Close();

            } catch (Exception ex)
            {

                //There was an Error
                Label1.Text = "Error 1001";
            }

        }
    }
}