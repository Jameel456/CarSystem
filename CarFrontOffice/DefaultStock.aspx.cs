using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DefaultStock : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            //update the list box
            DisplayStocks();

        }
    }

    void DisplayStocks()
    {
        //create an instance of the county collection
        CarClasses.clsStockCollection Stocks = new CarClasses.clsStockCollection();
        //set the data source to the list of counties in the collection
        lstStock.DataSource = Stocks.StockList;
        //set the name of the primary key
        lstStock.DataValueField = "ModelNo";
        //set the field to display
        lstStock.DataTextField = "CarModel";
        //bind the data to the list
        lstStock.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["ModelNo"] = -1;
        //reirect to entry page
        Response.Redirect("AStock.aspx");
    }
}