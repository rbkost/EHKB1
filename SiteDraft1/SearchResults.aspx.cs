using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;
using System.Data.Linq;
using System.Data;

/// <summary>
/// Script : SearchResults.aspx.cs
/// Project : Excela Health Knowledge Base
/// 
/// This .cs file is the code behind SearchResults.aspx for retreiving and displaying the users requested
/// data. This code will access the SQL server using DataLinq.dbml to retreive and display data
/// 
/// Copyright 2016 Excela Health
/// 
/// Last Revision: 11/12/16 : R Brian Kost, Support Center Analyst
/// 
/// </summary>

namespace SiteDraft1
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        String SearchRequest; //Receiving string var
        List<string> returnList = new List<string>(); //General List of Search Results
        List<string> PurgedList = new List<string>(); //List removing Doubles

        DataTable Results = new DataTable(); //Search Results DataTable
        DataTable SortedResults = new DataTable(); //Sorted DataTable

        protected void Page_Load(object sender, EventArgs e) //Page Load function
        {
            //get the request from the previous page
            SearchRequest = Request.QueryString["request"];
            //split the words that they searched for into an array
            string[] searchwords = SearchRequest.Split(' ');

            //foreach loop adding the search word to a list
            foreach(string word in searchwords)
            {
                returnList.Add(word);
            }

            PurgedList = returnList.Distinct().ToList(); //purged to remove doubles

            //Setting up the Beginning DataTable
            Results.Clear();  //Clears the Datatable for Safe Return of Data
            Results.Columns.Add("ID"); //Add Column 1
            Results.Columns.Add("HitCount"); //Add Column 2

            //Start the GetMatching Subroutine to get the results
            GetMatching();
        }

        //Gets Results from the search and places them on the page
        public void GetMatching()
        {
            //Datalinq to SQL database using DataLinq.dbml
            DataLinqDataContext db = new DataLinqDataContext();
            Table<EHKB> ehKB = db.GetTable<EHKB>();





            foreach (string word in PurgedList) //check the database for each word
            {

                //run query
                var query =
                from id in ehKB
                where id.Tags.Contains(word.ToLower())
                select id;

                //add each found id to DataTable "Results"
                foreach (var id in query)
                {
                    DataRow[] foundids = Results.Select("ID = '" + id.id + "'");

                    //check if already found a matching tag and and adds to running tally of matches or adds to the DataSet if it's the first
                    //match found. 
                    if (foundids.Length != 0)
                    {
                        // match found add one to count for that result
                        int Index = Results.Rows.IndexOf(foundids[0]); //get the index of the row found
                        string countpre = Results.Rows[Index]["HitCount"].ToString();
                        int Count = Int32.Parse(countpre);
                        Count++;
                        Results.Rows[Index].SetField("HitCount", Count.ToString());
                    
                     

                    }
                    else
                    {
                        //no match found - Add the ID and a value of 1 (count)
                        DataRow _resultfound = Results.NewRow();
                        _resultfound["ID"] = id.id;
                        _resultfound["HitCount"] = "1";
                        Results.Rows.Add(_resultfound);

                    }

                }

                //Sort the Data by the number of tag hits
                DataView Sorted = Results.DefaultView;
                Sorted.Sort = "HitCount desc";
                SortedResults = Sorted.ToTable();
            
            }


            //set up x to count number of results
            int x = 0;

            //puts the data on the page in order of number of tag hits
            foreach(DataRow row in SortedResults.Rows)
            {

                int _curID = Convert.ToInt32(row["ID"]);

                var query =
                    from ids in ehKB
                    where ids.id.Equals(_curID)
                    select ids;

                foreach (var id in query)
                {

                    System.Web.UI.HtmlControls.HtmlGenericControl Result =
                    new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                    Result.ID = "createDiv";
                    string linkto = "PageLoad.aspx?request=" + row["ID"].ToString() + ">";
                    
                    Result.InnerHtml = "<font size=5> <a href=" + linkto + row["ID"].ToString() + ": " + id.Summary + "</a> </font><font size=1>" + "" + id.DataAdded + "</font>";
                    this.Controls.Add(Result);


                    System.Web.UI.HtmlControls.HtmlGenericControl Result2 =
                    new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                    Result2.ID = "createDiv";
                    Result2.InnerHtml = "<font size=2>" + id.LongDescription + "</font><br /><br /><br />";
                    this.Controls.Add(Result2);
                    x++;

                }
            }

            //Places number of search results at the top
            ReturnCount.Text = x.ToString();

        }

        //searchButtonClick
        protected void SearchButton_Click(object sender, EventArgs e)
        {
            string Data = SearchBox.Text;

            ErrorLbl.Text = Data;

            if (string.IsNullOrEmpty(Data))
            {
                //see if SearchBox is blank, if it is blank, prompt user that data is needed or do nothing.
                DisplayError();

            }
            else
            {
                //Send to Search page with Data Information
                Response.Redirect("SearchResults.aspx?request=" + Data);
               
            }

        }

        private void DisplayError()
        {
            //Show error then do nothing
            ErrorLbl.Text = "Search field can not be empty!";

        }
    }
}