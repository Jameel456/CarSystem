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
}