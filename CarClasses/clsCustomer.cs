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

        public string Valid(string customerID, string customerName, string customerTelNumber, string customerAddress, string dateJoined)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store date values
            Int32 IntTemp;
            DateTime DateTemp;
            if (customerName.Length == 0)
            {
                //record the error
                Error = Error + "the customer name may not be blank : ";
            }
            //if the customer name is greater than 50 characters
            if (customerName.Length > 50)
            {
                //record the error
                Error = Error + "The customer name must be less than 50 characters!";
            }
            try
            {
                //copy the datejoined value to the datetemp variable
                DateTemp = Convert.ToDateTime(dateJoined);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error 
                    Error = Error + "The date cannot be in the past :";
                }

                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error 
                    Error = Error + "The date cannot be in the future :";
                }
            }
            catch
            {
                //record the error
                Error = Error + "the date was not a valid date :";
            }
            {
               

                if (customerAddress.Length == 0)
                {
                    //record the error
                    Error = Error + "the customer address may not be blank : ";
                }

                //if the customer address is greater than 50 characters
                if (customerAddress.Length > 50)
                {
                    //record the error
                    Error = Error + "The customer address must be less than 50 characters!";
                }
                {
                    if (customerTelNumber.Length == 0)
                    {
                        //record the error
                        Error = Error + "the customer telephone number may not be blank : ";
                    }

                    //if the customer address is greater than 12 characters
                    if (customerTelNumber.Length > 11)
                    {
                        //record the error
                        Error = Error + "The customer telephone number must be less than 12 characters!";
                    }
                }

                try
                {
                    //copy the datejoined value to the datetemp variable
                    IntTemp = Convert.ToInt32(customerID);
                    if (IntTemp < 1)
                    {
                        //record the error 
                        Error = Error + "The record needs to be a valid record :";
                    }

                    if (IntTemp > 500)
                    {
                        //record the error 
                        Error = Error + "The record cannot be more than 500 :";
                    }
                }

                catch
                {
                    //record the error
                    Error = Error + "the record was not a valid record :";
                }


                //return any error messages
                return Error;
            }

        }
        }
    }
