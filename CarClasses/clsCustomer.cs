using System;

namespace CarClasses
{
    public class clsCustomer
    {
        //private data member for the customer id property
        private Int32 mCustomerID;
        //private memeber for the property
        private DateTime mDateJoined;
        //private memeber for the property
        private string mCustomerName;
        //private memeber for the property
        private string mCustomerTelNumber;
        //private memeber for the property
        private string mCustomerAddress;
        //private memeber for the property
        private Boolean mActive;
        public bool Active
        {
            get
            {
                //this line of code sends data out og the proeprty
                return mActive;
            }
            set
            {
                //this line of code allows data into the property
                mActive = value;
            }
        }
        //DateADDED private data member variable
        public DateTime DateJoined
        {
            get
            {
                //this line of code sends data out og the proeprty
                return mDateJoined;
            }
            set
            {
                //this line of code allows data into the property
                mDateJoined = value;
            }
        }

        public Int32 CustomerID
        {

            get
            {
                //this line of code sends data out og the proeprty
                return mCustomerID;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerID = value;
            }
        }
        public string CustomerTelNumber
        {

            get
            {
                //this line of code sends data out og the proeprty
                return mCustomerTelNumber;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerTelNumber = value;
            }
        }

        public string CustomerAddress
        {

            get
            {
                //this line of code sends data out og the proeprty
                return mCustomerAddress;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerAddress = value;
            }
        }
        public string CustomerName
        {

            get
            {
                //this line of code sends data out og the proeprty
                return mCustomerName;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerName = value;
            }
        }

        public bool Find(int CustomerID)
        {
            //create an insatnce of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the customer id to search for
            DB.AddParameter("@CustomerId", CustomerID);
            //execute the stroed procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerId");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["Customerid"]);
                mCustomerName = Convert.ToString(DB.DataTable.Rows[0]["CustomerName"]);
                mCustomerAddress = Convert.ToString(DB.DataTable.Rows[0]["CustomerAddress"]);
                mCustomerTelNumber = Convert.ToString(DB.DataTable.Rows[0]["CustomerTelNumber"]);
                mDateJoined = Convert.ToDateTime(DB.DataTable.Rows[0]["DateJoined"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        //set the private data members to the test data value
        //   mCustomerID = 20;
        //   mDateJoined = Convert.ToDateTime("17/09/2019");
        //   mCustomerName = "Test Customer Name";
        //   mCustomerTelNumber = "07864128973";
        //     mCustomerAddress = "21 London Road";
        //     mActive = true;
        //alwsy return true
        //   return true;
    }
    }
