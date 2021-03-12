using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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

    }

    protected void btnApplyCustomer_Click(object sender, EventArgs e)
    {

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
}