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
        //capture stock no
        string CarModel = txtCarModel.Text;
        string BHP = txtBHP.Text;
        Int32 Price = Convert.ToInt32(txtPrice.Text);
        string DateAdded = txtDateAdded.Text;
        string Error = "";
        //Validate the data
        Error = AStock.Valid(CarModel, BHP, Price, DateAdded);
        if (Error == "")
        {
            //capture the  stock no
            AStock.CarModel = txtCarModel.Text;
            AStock.BHP = txtBHP.Text;
            AStock.Price = Convert.ToInt32(txtPrice.Text);
            AStock.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
            //store the bjp in th esession
            Session["AStock"] = AStock;
            //redirect the viewer page
            Response.Redirect("StockViewer.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the qddress class
        clsStock AStock = new clsStock();
        //variable to store in the primary key
        Int32 ModelNo;
        //variable 
        Boolean Found=false;
        //get primary key
        ModelNo = Convert.ToInt32(txtModelNo.Text);
        //find the record
        Found = AStock.Find(ModelNo);
        //if found
        if (Found == true)
        {
            //display the  values of the proerptries in the forkm
            txtBHP.Text = AStock.BHP;
            txtCarModel.Text = AStock.CarModel;
            txtDateAdded.Text = AStock.DateAdded.ToString();
            txtPrice.Text = AStock.Price.ToString();
        }
    }
}