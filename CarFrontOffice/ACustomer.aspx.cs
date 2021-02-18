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
}