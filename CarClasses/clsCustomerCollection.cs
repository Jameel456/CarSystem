using System;
using System.Collections.Generic;


namespace CarClasses
{
    public class clsCustomerCollection
    {
        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //private data memeber thisCustomer
        clsCustomer mThisCustomer = new clsCustomer();



        public List<clsCustomer> CustomerList
        {
            get
            {
                //return the private data
                return mCustomerList;
            }
            set
            {
                //set the private data
                mCustomerList = value;
            }
        }
        public int Count
        {
            get
            {
                //return the count of  the lsit
                return mCustomerList.Count;
            }
            set
            { //we shall worry about this later
            }
        }

        public int Add()
        {
            //adds a new record to the database based on the values of mThisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the paramters for the stored procedure
            DB.AddParameter("@CustomerName", mThisCustomer.CustomerName);
            DB.AddParameter("@CustomerTelNumber", mThisCustomer.CustomerTelNumber);
            DB.AddParameter("@CustomerAddress", mThisCustomer.CustomerAddress);
            DB.AddParameter("@DateJoined", mThisCustomer.DateJoined);
            DB.AddParameter("@Active", mThisCustomer.Active);
            //return the primary key of the new record
            return DB.Execute("sproc_tblCustomer_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisCustomer
            //connect the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_Delete");
        }

       public void Update()
        {
            //update the existing record bsaed on the values of thisCustomer
            //connect the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters to the stored procedure
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            DB.AddParameter("@CustomerName", mThisCustomer.CustomerName);
            DB.AddParameter("@CustomerTelNumber", mThisCustomer.CustomerTelNumber);
            DB.AddParameter("@CustomerAddress", mThisCustomer.CustomerAddress);
            DB.AddParameter("@DateJoined", mThisCustomer.DateJoined);
            DB.AddParameter("@Active", mThisCustomer.Active);
            //return the primary key of the new record
            DB.Execute("sproc_tblCustomer_Update");
        }


        public clsCustomer ThisCustomer
        {
            get
            {
                //return the private data
                return mThisCustomer;
            }
            set
            {
                //set the private data
                mThisCustomer = value;

            }
        }

        public clsCustomerCollection()
        {
            ////var for the index 
            //Int32 Index = 0;
            ////var to store the record count
            //Int32 RecordCount = 0;
            //object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);

            ////get the coint of records
            //RecordCount = DB.Count;
            ////while there are records to process
            //while (Index < RecordCount)
            //{
            //    //create a blank address
            //    clsCustomer ACustomer = new clsCustomer();
            //    //read in the fields from the current record
            //    ACustomer.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
            //    ACustomer.CustomerID= Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
            //    ACustomer.CustomerName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerName"]);
            //    ACustomer.CustomerTelNumber = Convert.ToString(DB.DataTable.Rows[Index]["CustomerTelNumber"]);
            //    ACustomer.CustomerAddress = Convert.ToString(DB.DataTable.Rows[Index]["CustomerAddress"]);
            //    ACustomer.DateJoined = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateJoined"]);
            //    //add the record to the private data member
            //    mCustomerList.Add(ACustomer);
            //    //point at the next record
            //    Index++;
            }
            //create the items of the test data
            //clsCustomer TestItem = new clsCustomer();
            ////set its properties
            //TestItem.Active = true;
            //TestItem.CustomerID = 1;
            //TestItem.CustomerName = "Jeff Adams";
            //TestItem.CustomerTelNumber = "07896432654";
            //TestItem.CustomerAddress = "45 Leicester Street";
            //TestItem.DateJoined = DateTime.Now.Date;
            ////add the item to the test list
            //mCustomerList.Add(TestItem);
            ////re intialise the object for some new data
            //TestItem = new clsCustomer();
            ////set its properties
            //TestItem.Active = true;
            //TestItem.CustomerID = 2;
            //TestItem.CustomerName = "Hussein Patel";
            //TestItem.CustomerTelNumber = "07812378592";
            //TestItem.CustomerAddress = "21 Melton Streett";
            //TestItem.DateJoined = DateTime.Now.Date;

            //mCustomerList.Add(TestItem);


        

        public void ReportByCustomerName(string CustomerName)
        {
            //filters the records based on a full or partial customer name
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the customername parameter to the database
            DB.AddParameter("@CustomerName", CustomerName);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerName");
        PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populated the array lsit based on the data table in the paramter DB
            //var for the index 
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mCustomerList = new List<clsCustomer>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //Create a blank customer
                clsCustomer ACustomer = new clsCustomer();
                //read in the fields from the current record
                ACustomer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                ACustomer.CustomerName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerName"]);
                ACustomer.CustomerTelNumber = Convert.ToString(DB.DataTable.Rows[Index]["CustomerTelNumber"]);
                ACustomer.CustomerAddress = Convert.ToString(DB.DataTable.Rows[Index]["CustomerAddress"]);
                ACustomer.DateJoined = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateJoined"]);
                ACustomer.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                //add the record to the private data member
                mCustomerList.Add(ACustomer);
                //point at the next record
                Index++;
            }
        }
    }
}