using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            //update the list box
           
            DisplayCustomers();
            DisplayStaff();
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

    void DisplayStaff()
    {
        //create an instance of the staff collection 
        CarClasses.clsStaffCollection Staff = new CarClasses.clsStaffCollection();
        //set the data source
        lstStaff.DataSource = Staff.StaffList;
        //set the name of the primary key
        lstStaff.DataValueField = "StaffID";
        //set the data field to display
        lstStaff.DataTextField = "StaffName";
        //bind the data to the list
        lstStaff.DataBind();
    }
}