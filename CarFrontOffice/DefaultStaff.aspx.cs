using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DefaultStaff : System.Web.UI.Page
{
   protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            //update the list box        
            DisplayStaff();
        }
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

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["StaffID"] = -1;
        //reirect to entry page
        Response.Redirect("AStaff.aspx");
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {

    }
}