using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Data;

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

            searchstring = "SELECT Id from EHKB WHERE Tags = 'test'";

            List<string> returnList = new List<string>();            

            try
            {
                command = new SqlCommand(searchstring, myConnection);
                reader = command.ExecuteReader();

               
                string output = "";
                while (reader.Read())
                {
                    returnList.Add(reader.GetInt32(0).ToString());
                    
                    
                

                }

                // DataTable dt = new DataTable();


                //   while (reader.Read())
                //    {
                // dt.Load(reader);

                //     }

                //     string output = "";

                //     foreach (DataRow rows in dt.Rows)
                //     {
                //         output = output + rows.ToString() + "\n";
                //     }

                foreach(string result in returnList) {

                    output = output + result.ToString() + "\n";
                    Label1.Text = output;
                    

                }
                reader.Close();
                command.Dispose();
                myConnection.Close();

            } catch (Exception ex)
            {

                //There was an Error
                Label1.Text = ex.ToString();
            }

        }
    }
}