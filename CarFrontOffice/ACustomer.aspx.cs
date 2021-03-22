using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarClasses;

public partial class ACustomer : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 CustomerID;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the customerid to be processed
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
        if (IsPostBack == false)
        {
            //populate the list of customers
            DisplayCustomers();
            //if this is not a new record
            if(CustomerID != -1)
            {
                //display the current data for the record
                DisplayCustomers();
            }
        }

      
    }

    void DisplayCustomers()
    {
        //create an instacne of the customer book
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        //find the record to update
        CustomerBook.ThisCustomer.Find(CustomerID);
        //display the data for this record
        txtCustomerName.Text = CustomerBook.ThisCustomer.CustomerName;
        txtCustomerTelNumber.Text = CustomerBook.ThisCustomer.CustomerTelNumber;
        txtCustomerAddress.Text = CustomerBook.ThisCustomer.CustomerAddress;
        txtDateJoined.Text = CustomerBook.ThisCustomer.DateJoined.ToString();
        ChkActive.Checked = CustomerBook.ThisCustomer.Active;

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {if (CustomerID == -1)
        {
            //add the new record
            Add();

        }
    else
        {
            //update the record
            Update();
        }
        //add the new record
        Add();
        //all done so redirecr back to the main page
       // Response.Redirect("DefaultCustomer.aspx");
       // create a new instance of clsCustomer
        clsCustomer ACustomer = new clsCustomer();
        
               //capture the customer na
        //  string CustomerID = txtCustomerID.Text;
        string CustomerName = txtCustomerName.Text;
        //capture the customer telephone number
        string CustomerTelNumber = txtCustomerTelNumber.Text;
        //capture the customer address
        string CustomerAddress = txtCustomerAddress.Text;
        //capture the date joined
        string DateJoined = txtDateJoined.Text;
        //Capture Error
        string Error = "";
        //validate the data
        Error = ACustomer.Valid("1", CustomerName, CustomerTelNumber, CustomerAddress, DateJoined);
        if (Error == "")
        {
            ACustomer.CustomerID = CustomerID;
            //capture the customer name
            ACustomer.CustomerName = CustomerName;
            //capture the customer telephone number
            ACustomer.CustomerTelNumber = CustomerTelNumber;
            //capture the customer address
            ACustomer.CustomerAddress = CustomerAddress;
            //capture the date joined
            ACustomer.DateJoined = Convert.ToDateTime(DateJoined);

            //store the address in the session object 
            Session["ACustomer"] = ACustomer;
            //redirect to the viewer page
            // Response.Redirect("CustomerViewer.aspx");
            Response.Redirect("DefaultCustomer.aspx");

        }
        else
        {
            lblError.Text = Error;
        }
        // capture the customer name
     //   ACustomer.CustomerID = txtCustomerID.Text;
        ACustomer.CustomerName = txtCustomerName.Text;
        ACustomer.CustomerAddress = txtCustomerAddress.Text;
        ACustomer.CustomerTelNumber = txtCustomerTelNumber.Text;
        ACustomer.DateJoined = DateTime.Now;


    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the class
        clsCustomer ACustomer = new clsCustomer();
        //variable to store the primary key
        Int32 CustomerID;
        //varaible to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered  by the user
        CustomerID = Convert.ToInt32(txtCustomerID.Text);
        //find the record
        Found = ACustomer.Find(CustomerID);
        //if found
        if (Found == true)
        {
            //display the valyes of the properties in the form
            txtCustomerName.Text = ACustomer.CustomerName;
            txtCustomerAddress.Text = ACustomer.CustomerAddress;
            txtCustomerTelNumber.Text = ACustomer.CustomerTelNumber;
            txtDateJoined.Text = ACustomer.DateJoined.ToString();
        }
    }

    void Add()
    {
        //create an instance of the Customer Book
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        //validate the data on the web form
        String Error = CustomerBook.ThisCustomer.Valid(txtCustomerID.Text, txtCustomerName.Text, txtCustomerTelNumber.Text, txtCustomerAddress.Text, txtDateJoined.Text);
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //get the data entered by the user
            CustomerBook.ThisCustomer.CustomerID = Convert.ToInt32(txtCustomerID.Text);
            CustomerBook.ThisCustomer.CustomerName = txtCustomerName.Text;
            CustomerBook.ThisCustomer.CustomerTelNumber = txtCustomerTelNumber.Text;
            CustomerBook.ThisCustomer.CustomerAddress = txtCustomerAddress.Text;
            CustomerBook.ThisCustomer.DateJoined = Convert.ToDateTime(txtDateJoined.Text);
            CustomerBook.ThisCustomer.Active = ChkActive.Checked;
            //add the record
            CustomerBook.Add();
            //all done so redirect back to the main page
            Response.Redirect("DefaultCustomer.aspx");

        }

        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered" + Error;
        }

     

    }
    void Update()
    {
        //create an instance of the Customer Book
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        //validate the data on the web form
        String Error = CustomerBook.ThisCustomer.Valid(txtCustomerID.Text, txtCustomerName.Text, txtCustomerTelNumber.Text, txtCustomerAddress.Text, txtDateJoined.Text);
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //find the record to update
            CustomerBook.ThisCustomer.Find(CustomerID);
            //get the data entered by the user
            CustomerBook.ThisCustomer.CustomerID = Convert.ToInt32(txtCustomerID.Text);
            CustomerBook.ThisCustomer.CustomerName = txtCustomerName.Text;
            CustomerBook.ThisCustomer.CustomerTelNumber = txtCustomerTelNumber.Text;
            CustomerBook.ThisCustomer.CustomerAddress = txtCustomerAddress.Text;
            CustomerBook.ThisCustomer.DateJoined = Convert.ToDateTime(txtDateJoined.Text);
            CustomerBook.ThisCustomer.Active = ChkActive.Checked;
            //Update the record
            CustomerBook.Update();
            //all done so redirect back to the main page
            Response.Redirect("DefaultCustomer.aspx");

        }

        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered" + Error;
        }



    }





    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect to main page
        Response.Redirect("DefaultCustomer.aspx");
    }

    protected void txtCustomerAddress_TextChanged(object sender, EventArgs e)
    {

    }
}