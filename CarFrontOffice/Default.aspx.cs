using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
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
        lstStocks.DataSource = Stocks.StockList;
        //set the name of the primary key
        lstStocks.DataValueField = "ModelNo";
        //set the field to display
        lstStocks.DataTextField = "CarModel";
        //bind the data to the list
        lstStocks.DataBind();
    }
}