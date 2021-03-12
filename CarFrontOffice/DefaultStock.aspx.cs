using CarClasses;
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
        clsStockCollection Stocks = new clsStockCollection();
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

    //protected void btnDelete_Click(object sender, EventArgs e)
    //{
    //    //var to store the primary key value of the record to be deleted
    //    Int32 ModelNo;
    //    //if a record has beeen selectedf from the list
    //    if (lstStock.SelectedIndex != -1)
    //    {
    //        //get the primary key value of the record to delete
    //        ModelNo = Convert.ToInt32(lstStock.SelectedValue);
    //        //store the data in session ibject
    //        Session["ModelNo"] = ModelNo;
    //        //redirect to the delete page
    //        Response.Redirect("DeleteStock.aspx");
    //    }
    //    else //if no record has been selected
    //    {
    //        //display error
    //        lblError.Text = "Please select a record to edit from the list";
    //    }
    //}



    //protected void btnEdit_Click(object sender, EventArgs e)
    //{
    //    //var to store the primary key value of the record to be deleted
    //    Int32 ModelNo;
    //    //if a record has beeen selectedf from the list
    //    if (lstStock.SelectedIndex != -1) 
    //    {
    //        //get the primary key value of the record to delete
    //        ModelNo = Convert.ToInt32(lstStock.SelectedValue);
    //        //store the data in session ibject
    //        Session["ModelNo"] = ModelNo;
    //        //redirect to the delete page
    //        Response.Redirect("AStock.aspx");
    //    }
    //    else //if no record has been selected
    //    {
    //        //display error
    //        lblError.Text = "Please select a record to edit from the list";
    //    }
    //}
}