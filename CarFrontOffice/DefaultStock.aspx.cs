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
        //create an instance of the county collectionhello
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


    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 ModelNo;
        //if a record has beeen selectedf from the list
        if (lstStock.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            ModelNo = Convert.ToInt32(lstStock.SelectedValue);
            //store the data in session ibject
            Session["ModelNo"] = ModelNo;
            //redirect to the delete page
            Response.Redirect("DeleteStock.aspx");
        }
        else //if no record has been selected
        {
            //display error
            lblError.Text = "Please select a record to edit from the list";
        }
    }



    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 ModelNo;
        //if a record has beeen selectedf from the list
        if (lstStock.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            ModelNo = Convert.ToInt32(lstStock.SelectedValue);
            //store the data in session ibject
            Session["ModelNo"] = ModelNo;
            //redirect to the delete page
            Response.Redirect("AStock.aspx");
        }
        else //if no record has been selected
        {
            //display error
            lblError.Text = "Please select a record to edit from the list";
        }


    }

   

    Int32 DisplayStocks(string CarModelFilter)
    {

        Int32 ModelNo; //var to store the primary key
        string CarModel; //var to store the phone type
        string BHP; //var to store the phone number
        DateTime DateAdded;
        //; //create an onstance of the phone book class
        //create an instance of the phone collection class
        clsStockCollection StockBook = new clsStockCollection();
        StockBook.ReportByCarModel(CarModelFilter);
        Int32 RecordCount; // var to store the count of records
        Int32 Index = 0; // var to store the index for the loop
        RecordCount = StockBook.Count; // get the count of records
        lstStock.Items.Clear();
        while (Index < RecordCount) // while there are records to process
        {
            ModelNo = StockBook.StockList[Index].ModelNo; // get the primary key 
            CarModel = StockBook.StockList[Index].CarModel; // get the phone type
            BHP = StockBook.StockList[Index].BHP; // get the phone name
            DateAdded = StockBook.StockList[Index].DateAdded; // get the phone name
            //create a new entry for the list box 
            ListItem NewEntry = new ListItem(CarModel + " " + BHP + " " + DateAdded, ModelNo.ToString());
            lstStock.Items.Add(NewEntry); // ADD THE PHONE TO THE LIST 
            Index++;






        }
        return RecordCount; //return the count of records found
    }



    protected void btnDisplayAll_Click(object sender, EventArgs e)
    {
        DisplayStocks();
    }

    protected void btnApply_Click1(object sender, EventArgs e)
    {
        DisplayStocks(txtCarModelSearch.Text);
    }
}
