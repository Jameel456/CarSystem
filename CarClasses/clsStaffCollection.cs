using System;
using System.Collections.Generic;

namespace CarClasses
{
    public class clsStaffCollection
    {
            List<clsStaff> mStaffList = new List<clsStaff>();
            //private the data member thisStaff
            clsStaff mThisStaff = new clsStaff();
        


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
        public int Add()
        {
            //adds a new record to the database based on the values of thisStaff
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //set the parameter for the stored procedure 
            DB.AddParameter("@StaffName", mThisStaff.StaffName);
            DB.AddParameter("@StaffTelNumber", mThisStaff.StaffTelNumber);
            DB.AddParameter("@StaffAddress", mThisStaff.StaffAddress);
            DB.AddParameter("@DateJoined", mThisStaff.DateJoined);
            DB.AddParameter("@Active", mThisStaff.Active);
            //exeute the query retruning the primary key value
            return DB.Execute("sproc_tblStaff_Insert");

        }

        public void Delete()
        {
            //deletes the record pointed to by thisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure 
            DB.AddParameter("StaffID", mThisStaff.StaffID);
            //execute the store procedure
            DB.Execute("sproc_tblStaff_Delete");
        }

        public void Update()
        {
            //adds a new record to the database based on the values of thisStaff
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //set the parameter for the stored procedure            
            DB.AddParameter("@StaffName", mThisStaff.StaffName);
            DB.AddParameter("@StaffTelNumber", mThisStaff.StaffTelNumber);
            DB.AddParameter("@StaffAddress", mThisStaff.StaffAddress);
            DB.AddParameter("@DateJoined", mThisStaff.DateJoined);
            DB.AddParameter("@StaffID", mThisStaff.StaffID);
            DB.AddParameter("@Active", mThisStaff.Active);
            //exeute the query retruning the primary key value
            DB.Execute("sproc_tblStaff_Update");

        }

        public clsStaff ThisStaff
        {
            get
            {
                return mThisStaff;
            }


            set
            {
                mThisStaff = value;
            }
           
        }


        //constructor for the class
        public clsStaffCollection()
        {
            {
                //var for the index
              //  Int32 Index = 0;
                //var to store the record count 
               // Int32 RecordCount = 0;
                //object for data connection
                clsDataConnection DB = new clsDataConnection();
                //execute the stored procedure
                DB.Execute("sproc_tblStaff_SelectAll");
                //populate the array list with the data table
                PopulateArray(DB);
                //get the count of records
              //  RecordCount = DB.Count;
                //while there are records to process
             //   while (Index < RecordCount)
                //{
                //    //create a blank staff
                //    clsStaff AStaff = new clsStaff();
                //    //read in the fields from the current record               
                //    AStaff.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                //    AStaff.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
                //    AStaff.StaffName = Convert.ToString(DB.DataTable.Rows[Index]["StaffName"]);
                //    AStaff.StaffAddress = Convert.ToString(DB.DataTable.Rows[Index]["StaffAddress"]);
                //    AStaff.StaffTelNumber = Convert.ToString(DB.DataTable.Rows[Index]["StaffTelNumber"]);
                //    AStaff.DateJoined = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateJoined"]);
                //    //add the record to the private data member
                //    mStaffList.Add(AStaff);
                //    //point at the next record
                //    Index++;
                //}


                ////create the items of the test data
                //clsStaff TestItem = new clsStaff();
                ////set its properties
                //TestItem.Active = true;
                //TestItem.StaffID = 1;
                //TestItem.StaffName = "Hamzah";
                //TestItem.StaffAddress = "1 Leicester Road";
                //TestItem.StaffTelNumber = "07871740971";
                //TestItem.DateJoined = DateTime.Now.Date;
                ////add the item to the test list
                //mStaffList.Add(TestItem);
                //// re initialise the object for some new data
                //TestItem = new clsStaff();
                ////set its properties
                //TestItem.Active = true;
                //TestItem.StaffID = 2;
                //TestItem.StaffName = "Jameel";
                //TestItem.StaffAddress = "2 Manchester Road";
                //TestItem.StaffTelNumber = "07871740974";
                //TestItem.DateJoined = DateTime.Now.Date;
                ////add the item to the test list
                //mStaffList.Add(TestItem);
                ////constructor for the class
            }


        }

        public void ReportByStaffName(string StaffName)
        {
            //filter the records based on afull or partial post code 
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the StaffName parameter to the database
            DB.AddParameter("@StaffName", StaffName);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByStaffName");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
                //populates the array list based on the data table in the parameter DB
                //var for the index
                Int32 Index = 0;
                //var to store the record count 
                Int32 RecordCount;
                //get the count of records
                RecordCount = DB.Count;
                //clear the private array list 
                mStaffList = new List<clsStaff>();
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
            }
    }
}
                     
    

  

       
    

