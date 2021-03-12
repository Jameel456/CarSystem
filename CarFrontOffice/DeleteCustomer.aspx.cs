using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarClasses;




public partial class DeleteCustomer : System.Web.UI.Page
{ 
    //var to store the primary key value of the record to be deleted
    Int32 CustomerID;
    //event handler for the load event

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the customerId to be deleted from the session
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
    }


    void DeleteCustomers()
    {
        //function to delete the selected record
        //create a new instance of the customerbook
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        //find the record to delete 
        CustomerBook.ThisCustomer.Find(CustomerID);
        //delete the record
        CustomerBook.Delete();
    }

    protected void btnYesCustomer_Click(object sender, EventArgs e)
    {
        //delete the record 
        DeleteCustomers();
        //redirect  back to the main page
        Response.Redirect("DefaultCustomer.aspx");
    }

    protected void btnNoCustomer_Click(object sender, EventArgs e)
    {
        //redirect  back to the main page
        Response.Redirect("DefaultCustomer.aspx");
    }
}