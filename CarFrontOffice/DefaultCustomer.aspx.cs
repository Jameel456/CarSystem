using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarClasses;

public partial class DefaultCustomer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            //update the list box

            DisplayCustomers();
        }
    }

    void DisplayCustomers()
    {
        //create an instance of the customer collection
        CarClasses.clsCustomerCollection Customers = new CarClasses.clsCustomerCollection();
        //set the data source to the list of customers in the collection
        lstCustomers.DataSource = Customers.CustomerList;
        //set the data feild to display
        lstCustomers.DataValueField = "CustomerID";
        //SET THE DATA fiedl to display
        lstCustomers.DataTextField = "CustomerName";
        //bind the data to the list
        lstCustomers.DataBind();
    }

    protected void lstCustomers_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["CustomerID"] = -1;
        //redirect to the data enrty page
        Response.Redirect("ACustomer.aspx");
    }

    protected void btnCustomerDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 CustomerID;
        //if a record has been selected from the list
        if(lstCustomers.SelectedIndex != -1)
        {
            //get the primary key value of the record delete
            CustomerID = Convert.ToInt32(lstCustomers.SelectedValue);
            //store the data in the session object
            Session["CustomerID"] = CustomerID;
            //redirecr to the delete page
            Response.Redirect("DeleteCustomer.aspx");
            
        }
        else //if no record has been selected
        {
            //display an error
            lblErrorCustomer.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnDisplayAllCustomer_Click(object sender, EventArgs e)
    {
        DisplayCustomers();
    }

    protected void btnApplyCustomer_Click(object sender, EventArgs e)
    {
        //display all customers
        DisplayCustomers(txtCustomerSearch.Text);
    }

    Int32 DisplayCustomers(string CustomerNameFilter)
    {

        Int32 CustomerID; //var to store the primary key
        string CustomerName; //var to store the customer name
        string CustomerTelNumber; //var to store the customer tel number
        string CustomerAddress; // var to store the customer address
        //; //create an onstance of the customer book class
        //create an instance of the customer collection class
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        CustomerBook.ReportByCustomerName(CustomerNameFilter);
        Int32 RecordCount; // var to store the count of records
        Int32 Index = 0; // var to store the index for the loop
        RecordCount = CustomerBook.Count; // get the count of records
        lstCustomers.Items.Clear();
        while (Index < RecordCount) // while there are records to process
        {
            CustomerID = CustomerBook.CustomerList[Index].CustomerID; // get the primary key 
            CustomerName = CustomerBook.CustomerList[Index].CustomerName; // get the customer name
            CustomerTelNumber = CustomerBook.CustomerList[Index].CustomerTelNumber; // get the customer tel number
            CustomerAddress = CustomerBook.CustomerList[Index].CustomerAddress; // get the customeraddress
            //create a new entry for the list box 
            ListItem NewEntry = new ListItem(CustomerName + " " + CustomerAddress + " " + CustomerTelNumber, CustomerID.ToString());
            lstCustomers.Items.Add(NewEntry); // ADD THE Customer TO THE LIST 
            Index++;



   


        }
        return RecordCount; //return the count of records found


    }



        protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 CustomerID;
        //if a record has been selected from the list
        if (lstCustomers.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            CustomerID = Convert.ToInt32(lstCustomers.SelectedValue);
            //store the data in the session object
            Session["CustomerID"] = CustomerID;
            //redirecr to the delete page
            Response.Redirect("ACustomer.aspx");
        }
        else
             //if no record has been selected
        {
            //display an error
            lblErrorCustomer.Text = "Please select a record to delete from the list";
        }
    }

    protected void txtCustomerSearch_TextChanged(object sender, EventArgs e)
    {
        
    }

    protected void btnDisplayAllCustomers_Click(object sender, EventArgs e)
    {
        DisplayCustomers();
    }
}