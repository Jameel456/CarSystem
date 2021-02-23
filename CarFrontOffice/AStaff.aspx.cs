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



    protected void btnFind_Click1(object sender, EventArgs e)
    {
        //create an instance of the staff class
        clsStaff AStaff = new clsStaff();
        //variable to store the primary key
        Int32 StaffID;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        StaffID = Convert.ToInt32(txtStaffID.Text);
        //find the record
        Found = AStaff.Find(StaffID);
        //if found
        if (Found == true)
        {
            //display the value of the staff in form           
            txtStaffName.Text = AStaff.StaffName;
            txtStaffAddress.Text = AStaff.StaffAddress;
            txtStaffTelNumber.Text = AStaff.StaffTelNumber;
            txtDateJoined.Text = AStaff.DateJoined.ToString();
        }
    }
}