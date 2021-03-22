using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarClasses;

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



    protected void btnApply_Click(object sender, EventArgs e)
    {
        DisplayStaff(txtSearchStaff.Text);

    }
    Int32 DisplayStaff(string StaffNameFilter)
    {

        Int32 StaffID; //var to store the primary key
        string StaffName; //var to store the phone type
        string StaffTelNumber; //var to store the phone number
        string StaffAddress;
        //; //create an onstance of the phone book class
        //create an instance of the phone collection class
        clsStaffCollection StaffBook = new clsStaffCollection();
        StaffBook.ReportByStaffName(StaffNameFilter);
        Int32 RecordCount; // var to store the count of records
        Int32 Index = 0; // var to store the index for the loop
        RecordCount = StaffBook.Count; // get the count of records
        lstStaff.Items.Clear();
        while (Index < RecordCount) // while there are records to process
        {
            StaffID = StaffBook.StaffList[Index].StaffID; // get the primary key 
            StaffName = StaffBook.StaffList[Index].StaffName; // get the phone type
            StaffTelNumber = StaffBook.StaffList[Index].StaffTelNumber; // get the phone name
            StaffAddress = StaffBook.StaffList[Index].StaffAddress; // get the phone name
                                                                    //create a new entry for the list box 
            ListItem NewEntry = new ListItem(StaffName + " " + StaffAddress + " " + StaffTelNumber, StaffID.ToString());
            lstStaff.Items.Add(NewEntry); // ADD THE STAFF TO THE LIST 
            Index++;

        }
        return RecordCount; //return the count of records found
    }
    protected void btnAddStaff_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["StaffID"] = -1;
        //reirect to entry page
        Response.Redirect("AStaff.aspx");
    }

    protected void btnDeleteStaff_Click(object sender, EventArgs e)
    {
     
            
    }

    protected void btnDeleteStaff_Click1(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 StaffID;
        if (lstStaff.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            StaffID = Convert.ToInt32(lstStaff.SelectedValue);
            //store the data in the session object
            Session["StaffID"] = StaffID;
            //redirect to the delete page
            Response.Redirect("DeleteStaff.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }

    }

    protected void btnEditStaff_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 StaffID;
        if (lstStaff.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            StaffID = Convert.ToInt32(lstStaff.SelectedValue);
            //store the data in the session object
            Session["StaffID"] = StaffID;
            //redirect to the delete page
            Response.Redirect("AStaff.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnDisplayAllStaff_Click(object sender, EventArgs e)
    {
        DisplayStaff();
    }
}