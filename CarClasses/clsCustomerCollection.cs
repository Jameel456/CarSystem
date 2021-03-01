﻿using System;
using System.Collections.Generic;


namespace CarClasses
{
    public class clsCustomerCollection
    {
        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();



        public List<clsCustomer> CustomerList
        {
            get
            {
                //return the private data
                return mCustomerList;
            }
            set
            {
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
        public clsCustomer ThisCustomer { get; set; }

        public clsCustomerCollection()
        {
            //var for the index 
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            //get the coint of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsCustomer ACustomer = new clsCustomer();
                //read in the fields from the current record
                ACustomer.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                ACustomer.CustomerID= Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                ACustomer.CustomerName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerName"]);
                ACustomer.CustomerTelNumber = Convert.ToString(DB.DataTable.Rows[Index]["CustomerTelNumber"]);
                ACustomer.CustomerAddress = Convert.ToString(DB.DataTable.Rows[Index]["CustomerAddress"]);
                ACustomer.DateJoined = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateJoined"]);
                //add the record to the private data member
                mCustomerList.Add(ACustomer);
                //point at the next record
                Index++;
            }
            //create the items of the test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.Active = true;
            TestItem.CustomerID = 1;
            TestItem.CustomerName = "Jeff Adams";
            TestItem.CustomerTelNumber = "07896432654";
            TestItem.CustomerAddress = "45 Leicester Street";
            TestItem.DateJoined = DateTime.Now.Date;
            //add the item to the test list
            mCustomerList.Add(TestItem);
            //re intialise the object for some new data
            TestItem = new clsCustomer();
            //set its properties
            TestItem.Active = true;
            TestItem.CustomerID = 2;
            TestItem.CustomerName = "Hussein Patel";
            TestItem.CustomerTelNumber = "07812378592";
            TestItem.CustomerAddress = "21 Melton Streett";
            TestItem.DateJoined = DateTime.Now.Date;

            mCustomerList.Add(TestItem);


        }
    }
}