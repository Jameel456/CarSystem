using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarClasses;

public partial class AStock : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsAstock
        clsStock AStock = new clsStock();
        //capture the customer stock no
        AStock.CarModel = txtCarModel.Text;
        AStock.BHP = txtBHP.Text;
        AStock.Price = txtPrice.Text;
        AStock.DateAdded = DateTime.Now;
        //store the bjp in th esession
        Session["AStock"] = AStock;
        //redirect the viewer page
        Response.Redirect("StockViewer.aspx");


    }
}