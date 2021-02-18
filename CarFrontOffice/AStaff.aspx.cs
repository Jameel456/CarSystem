using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarClasses;

public partial class AStaff : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff AStaff = new clsStaff();
        //capture the staff name
        AStaff.StaffName = txtStaffName.Text;
        AStaff.StaffAddress = txtStaffAddress.Text;
        AStaff.StaffTelNumber = txtStaffTelNumber.Text;
        AStaff.DateJoined = DateTime.Now;
        //store the address in the session object
        Session["AStaff"] = AStaff;
        //redirect to the viewer page 
        Response.Redirect("StaffViewer.aspx");
    }

    protected void txtStaffName_TextChanged(object sender, EventArgs e)
    {

    }

    
    

    
}