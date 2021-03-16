using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarClasses;

public partial class AStock : System.Web.UI.Page
{
    //variable to store the primary key woth the page level sco
    Int32 ModelNo;

    protected void Page_Load(object sender, EventArgs e)
    {
        ModelNo = Convert.ToInt32(Session["ModelNo"]);
        if (IsPostBack == false)
        {
           if (ModelNo != -1)
            {
                //display the current data for the record
                DisplayStock();
            }
           else
            {
                //update the record
                Update();
            }
        }

    }

    protected void btnOK_Click(object sender, EventArgs e)

    {

        if (ModelNo == -1)
        {
            //add th new record
            Add();
        }
        else
        {
            //update the record
            Update();
        }

        //all done so redirect back to main page
        //Response.Redirect("DefaultStock.aspx");

        //create a new instance of clsAstock
        clsStock AStock = new clsStock();
        //capture stock no
        string CarModel = txtCarModel.Text;
        string BHP = txtBHP.Text;
        string Price = txtPrice.Text;
        string DateAdded = txtDateAdded.Text;
        string Error = "";
        //Validate the data
        Error = AStock.Valid(CarModel, BHP, Price, DateAdded);
        if (Error == "")
        {
            //capture the  stock no
            AStock.CarModel = txtCarModel.Text;
            AStock.BHP = txtBHP.Text;
            AStock.Price = Convert.ToDecimal(txtPrice.Text);
            AStock.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
            //store the bjp in th esession
            Session["AStock"] = AStock;
            //redirect the viewer page
            Response.Redirect("DefaultStock.aspx");
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

    void Add()
    {
        //create an instance of the address book
        clsStockCollection StockBook = new clsStockCollection();
        //validate the data on the webform
        String Error = StockBook.ThisStock.Valid(txtCarModel.Text, txtBHP.Text, txtPrice.Text, txtDateAdded.Text);
        //if the data is ok then add it to obkect
        if (Error == "")
        {
            //get the data entered by the user
            StockBook.ThisStock.CarModel = txtCarModel.Text;
            StockBook.ThisStock.BHP = txtBHP.Text;
            StockBook.ThisStock.Price = Convert.ToDecimal(txtPrice.Text);
            StockBook.ThisStock.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
            StockBook.ThisStock.Availability = chkAvailability.Checked;
            //add the record
            StockBook.Add();
            //all done so redirect back to main page
            Response.Redirect("DefaultStock.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered" + Error;
        }
    }

    void Update()
    {
        //create an instance of the address book
        clsStockCollection StockBook = new clsStockCollection();
        //validate the data on the webform
        String Error = StockBook.ThisStock.Valid(txtCarModel.Text, txtBHP.Text, txtPrice.Text, txtDateAdded.Text);
        //if the data is ok then add it to obkect
        if (Error == "")
        {
            //find the record to update
            StockBook.ThisStock.Find(ModelNo);
            //get the data entered by the user
            StockBook.ThisStock.CarModel = txtCarModel.Text;
            StockBook.ThisStock.BHP = txtBHP.Text;
            StockBook.ThisStock.Price = Convert.ToDecimal(txtPrice.Text);
            StockBook.ThisStock.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
            StockBook.ThisStock.Availability = chkAvailability.Checked;
            //add the record
            StockBook.Update();
            //all done so redirect back to main page
            Response.Redirect("DefaultStock.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered" + Error;
        }
    }

    void DisplayStock()
    {
        //create an instance of the address book
        clsStockCollection StockBook = new clsStockCollection();
        //find the record to update
        StockBook.ThisStock.Find(ModelNo);
        //display the data for this record
        txtCarModel.Text = StockBook.ThisStock.CarModel;
        txtBHP.Text= StockBook.ThisStock.BHP;
        txtPrice.Text= StockBook.ThisStock.Price.ToString();
        txtDateAdded.Text = StockBook.ThisStock.DateAdded.ToString();
        chkAvailability.Checked = StockBook.ThisStock.Availability;
    }



    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("DefaultStock.aspx");
    }
}