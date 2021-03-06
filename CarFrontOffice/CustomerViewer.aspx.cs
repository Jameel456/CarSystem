﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarClasses;
public partial class CustomerViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of the clsCustomer
        clsCustomer ACustomer = new clsCustomer();
        //get the data from the session object
        ACustomer = (clsCustomer)Session["ACustomer"];
        //display the customer name for this entry
        Response.Write(ACustomer.CustomerName);
        Response.Write(ACustomer.CustomerAddress);
        Response.Write(ACustomer.CustomerTelNumber);
        Response.Write(ACustomer.DateJoined);
    }
}