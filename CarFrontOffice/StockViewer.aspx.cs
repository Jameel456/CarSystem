using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarClasses;

public partial class StockViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsStock
        clsStock AStock = new clsStock();
        //get the data from the session objcet
        AStock = (clsStock)Session["AStock"];
        //display the car model for ths entry
        Response.Write(AStock.CarModel);
        Response.Write(AStock.BHP);
        Response.Write(AStock.Price);
        Response.Write(AStock.DateAdded);
    }



}