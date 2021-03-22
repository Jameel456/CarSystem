using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarClasses;

public partial class DeleteStaff : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted
    Int32 StaffID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be deleted from the session 
        StaffID = Convert.ToInt32(Session["StaffID"]);
    }

    void DeleteStaffs()
    {
        //fuction to delete the selected record

        //create a new instance of the staff book
        clsStaffCollection StaffBook = new clsStaffCollection();
        //find the record to delete 
        StaffBook.ThisStaff.Find(StaffID);
        //delete the record
        StaffBook.Delete();
    }

    protected void btnYesStaff_Click(object sender, EventArgs e)
    {
        //delete the record
        DeleteStaffs();
        //redirect back to the main page
        Response.Redirect("DefaultStaff.aspx");
    }

    protected void btnNoStaff_Click(object sender, EventArgs e)
    {
        Response.Redirect("DefaultStaff.aspx");
    }
}