using System;
using System.Collections.Generic;

namespace CarClasses
{
    public class clsStaffCollection
    {
        List<clsStaff> mStaffList = new List<clsStaff>();


        //public property for the staff staff list
        public List<clsStaff> StaffList
        {
            get
            {
                //return the private data 
                return mStaffList;
            }
            set
            {
                //set the private
                mStaffList = value;
            }
        }

        public int Count
        {
            get
            {
                //return the count of the list
                return mStaffList.Count;
            }
            set
            {
                //we shall worry about this later
            }


        }

        public clsStaff ThisStaff
        { get; set; }



        //constructor for the class
        public clsStaffCollection()
        {
            {
                //var for the index
                Int32 Index = 0;
                //var to store the record count 
                Int32 RecordCount = 0;
                //object for data connection
                clsDataConnection DB = new clsDataConnection();
                //execute the stored procedure
                DB.Execute("sproc_tblStaff_SelectAll");
                //get the count of records
                RecordCount = DB.Count;
                //while there are records to process
                while (Index < RecordCount)
                {
                    //create a blank staff
                    clsStaff AStaff = new clsStaff();
                    //read in the fields from the current record               
                    AStaff.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                    AStaff.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
                    AStaff.StaffName = Convert.ToString(DB.DataTable.Rows[Index]["StaffName"]);
                    AStaff.StaffAddress = Convert.ToString(DB.DataTable.Rows[Index]["StaffAddress"]);
                    AStaff.StaffTelNumber = Convert.ToString(DB.DataTable.Rows[Index]["StaffTelNumber"]);
                    AStaff.DateJoined = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateJoined"]);
                    //add the record to the private data member
                    mStaffList.Add(AStaff);
                    //point at the next record
                    Index++;
                }


                //create the items of the test data
                clsStaff TestItem = new clsStaff();
                //set its properties
                TestItem.Active = true;
                TestItem.StaffID = 1;
                TestItem.StaffName = "Hamzah";
                TestItem.StaffAddress = "1 Leicester Road";
                TestItem.StaffTelNumber = "07871740971";
                TestItem.DateJoined = DateTime.Now.Date;
                //add the item to the test list
                mStaffList.Add(TestItem);
                // re initialise the object for some new data
                TestItem = new clsStaff();
                //set its properties
                TestItem.Active = true;
                TestItem.StaffID = 2;
                TestItem.StaffName = "Jameel";
                TestItem.StaffAddress = "2 Manchester Road";
                TestItem.StaffTelNumber = "07871740974";
                TestItem.DateJoined = DateTime.Now.Date;
                //add the item to the test list
                mStaffList.Add(TestItem);
                //constructor for the class
            }


        }
    }
}
                     
    

  

       
    

