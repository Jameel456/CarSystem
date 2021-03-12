using CarClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DeleteStock : System.Web.UI.Page
{
    //var tpo store the primary key value of the recrod to be deleted
    Int32 ModelNo;

    //event handler for the load event
    protected void Page_Load(object sender, EventArgs e)
    {
        ModelNo = Convert.ToInt32(Session["ModelNo"]);
    }
  
    void DeleteStocks()
    {
        //function to delete the selected record

        clsStockCollection StockBook = new clsStockCollection();
        //find the record to delete
        StockBook.ThisStock.Find(ModelNo);
        //delete the record
        StockBook.Delete();
    }
    protected void btnYes_Click(object sender, EventArgs e)
    {
        DeleteStocks();
        //redirect back to main page
        Response.Redirect("DefaultStock.aspx");
    }

  
}