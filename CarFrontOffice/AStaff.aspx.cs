using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarClasses;

public partial class AStaff : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 StaffID;

    //event handler for the page load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the staff to be processed
        StaffID = Convert.ToInt32(Session["StaffID"]);
        if (IsPostBack == false)
        {
            //populate the list of staff
            DisplayStaff();
            //if this is not a new record 
            if (StaffID != -1) 

            {
                //display the current data for the record
                DisplayStaff();
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (StaffID == -1)
        {
            //add the new record
            Add();
        }
        else
        {
            //update the record
            Update();
        }



        //all done so redirect back to the main page
        

        //create a new instance of clsStaff
        clsStaff AStaff = new clsStaff();
        //capture the staff name
        string StaffName = txtStaffName.Text;
        //capture the staff address
        string StaffAddress = txtStaffAddress.Text;
        //capture the staff tel number
        string StaffTelNumber = txtStaffTelNumber.Text;
        //capture date joined
        string DateJoined = txtDateJoined.Text;
        //variable to store any error mesages
       // string StaffID = txtStaffID.Text;
        string Error = "";
        //validate the data
        Error = AStaff.Valid(StaffName, StaffAddress, StaffTelNumber, DateJoined, "1");
        if (Error == "")
        {
            //capture the staff name
            AStaff.StaffName = StaffName;
            //capture the staff address
            AStaff.StaffAddress = StaffAddress;
            //capture the staff tel number
            AStaff.StaffTelNumber = StaffTelNumber;
            //capture date joined
            AStaff.DateJoined = Convert.ToDateTime(DateJoined);
            //store the address in the session object
            //AStaff.StaffID = Convert.ToInt32(txtStaffID);
            Session["AStaff"] = AStaff;
            //redirect to the viewer page 
            // Response.Redirect("StaffViewer.aspx");
            Response.Redirect("DefaultStaff.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
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

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("DefaultStaff.aspx");
    }

    //funtion for adding new records

    void Add()
    {
        //create an insatnce of the address book 
        clsStaffCollection StaffBook = new clsStaffCollection();
        //validate the data on the web form
        String Error = StaffBook.ThisStaff.Valid(txtStaffName.Text, txtStaffAddress.Text, txtStaffTelNumber.Text, txtDateJoined.Text, txtStaffID.Text);
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //get the data entered by the user
            StaffBook.ThisStaff.StaffName = txtStaffName.Text;
            StaffBook.ThisStaff.StaffAddress = txtStaffAddress.Text;
            StaffBook.ThisStaff.StaffTelNumber = txtStaffTelNumber.Text;        
            StaffBook.ThisStaff.DateJoined = Convert.ToDateTime(txtDateJoined.Text);
            StaffBook.ThisStaff.StaffID = Convert.ToInt32(txtStaffID.Text);
            StaffBook.ThisStaff.Active = chkActive.Checked;
            //add the record
            StaffBook.Add();
        }
        else
        {
            //report and error
            lblError.Text = "There was problems with data entered" + Error;
        }

    }

    //funtion for updating records
    void Update()
    {
        //create an insatnce of the address book 
        CarClasses.clsStaffCollection StaffBook = new CarClasses.clsStaffCollection();
        //validate the data on the web form
        String Error = StaffBook.ThisStaff.Valid(txtStaffName.Text, txtStaffAddress.Text, txtStaffTelNumber.Text, txtDateJoined.Text, txtStaffID.Text);
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //find the record to update
            StaffBook.ThisStaff.Find(StaffID);
            //get the data entered by the user
            StaffBook.ThisStaff.StaffName = txtStaffName.Text;
            StaffBook.ThisStaff.StaffAddress = txtStaffAddress.Text;
            StaffBook.ThisStaff.StaffTelNumber = txtStaffTelNumber.Text;
            StaffBook.ThisStaff.DateJoined = Convert.ToDateTime(txtDateJoined.Text);
            StaffBook.ThisStaff.StaffID = Convert.ToInt32(txtStaffID.Text);
            //add the record
            StaffBook.Update();
            //all done redirect back to the main page
            Response.Redirect("DefaultStaff");
        }
        else
        {
            //report and error
            lblError.Text = "There was problems with data entered" + Error;
        }

    }

    void DisplayStaff()
    {
        //create an instance of the staff book
        clsStaffCollection StaffBook = new clsStaffCollection();
        //find the record to update
        StaffBook.ThisStaff.Find(StaffID);
        //diplsay the data for this record 
        txtStaffName.Text = StaffBook.ThisStaff.StaffName;
        txtStaffAddress.Text = StaffBook.ThisStaff.StaffAddress;
        txtStaffTelNumber.Text = StaffBook.ThisStaff.StaffTelNumber;
        txtDateJoined.Text = StaffBook.ThisStaff.DateJoined.ToString();
        chkActive.Checked = StaffBook.ThisStaff.Active;
    }

}