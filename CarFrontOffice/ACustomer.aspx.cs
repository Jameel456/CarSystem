using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarClasses;

public partial class ACustomer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer ACustomer = new clsCustomer();
        //capture the customer name
        ACustomer.CustomerName = txtCustomerName.Text;
        ACustomer.CustomerAddress = txtCustomerAddress.Text;
        ACustomer.CustomerTelNumber = txtCustomerTelNumber.Text;
        ACustomer.DateJoined = DateTime.Now;
   
        //store the address in the session object 
        Session["ACustomer"] = ACustomer;
        //redirect to the viewer page
        Response.Redirect("CustomerViewer.aspx");
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
}