using System;

namespace CarClasses
{
  
    public class clsStaff
    
    {   //
        private Boolean mActive;

        public bool Active
        {
            get
            {
                return mActive;
            }
            set
            {
                mActive = value;
            }
        }
        //datejoined public property
        private DateTime mDateJoined;
        public DateTime DateJoined
        {
            get
            {
                return mDateJoined;
            }
            set
            {
                mDateJoined = value;
            }
        }
        //private data member for the staff id 
        private Int32 mStaffID;
        public int StaffID
        {
            get
            {
                //this line of code sends data out of the staff
                return mStaffID;
            }
            set
            {
                //this line of code allows data into the staff
                mStaffID = value;
            }
        }
        //staff address data
        private String mStaffAddress;
        public string StaffAddress
        {
            get
            {
                //this line of code sends data out of the staff
                return mStaffAddress;
            }
            set
            {
                //this line of code allows data into the staff
                mStaffAddress = value;
            }
        }
        //staff tel number data
        private String mStaffTelNumber;
        public string StaffTelNumber
        {
            get
            {
                //this line of code sends data out of the staff
                return mStaffTelNumber;
            }
            set
            {
                //this line of code allows data into the staff
                mStaffTelNumber = value;
            }
        }

        //staff name data
        private String mStaffName;
        public string StaffName
        {
            get
            {
                //this line of code sends data out of the staff
                return mStaffName;
            }
            set
            {
                //this line of code allows data into the staff
                mStaffName = value;
            }
        }

        public bool Find(int StaffID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the staff id to search for
            DB.AddParameter("@StaffID", StaffID);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByStaffID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            //set the private data members to test the data value
            {
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);

                mDateJoined = Convert.ToDateTime(DB.DataTable.Rows[0]["DateJoined"]);

                mStaffName = Convert.ToString(DB.DataTable.Rows[0]["StaffName"]);

                mStaffAddress = Convert.ToString(DB.DataTable.Rows[0]["StaffAddress"]);

                mStaffTelNumber = Convert.ToString(DB.DataTable.Rows[0]["StaffTelNumber"]);

                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]); 
                //always return true

                return true;
            }
            //if no record was found 
            else
            {
                //return false indicating a problem 
                return false;
            }
        }

        public string Valid(string staffName, string staffAddress, string staffTelNumber, string dateJoined, string staffID)
        {
            //create a string variable to store the erro
            String Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;
            //if the StaffName is blank
            Int32 IntTemp;
            if (staffName.Length == 0)
            {
                //record the error
                Error = Error + "The Staff Name may not be blank : ";
            }
            //if the staff name is greater than 50 characters
            if (staffName.Length > 50)
            {
                //record the error
                Error = Error + "The Staff Name must be less than 50 characters : ";
            }
            try
            {
                //copy the dateJoined value to the DateTemp variable

                DateTemp = Convert.ToDateTime(dateJoined);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greater than todays date

                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error 

                    Error = Error + "The date cannot be in the future";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date";
            }

            if (staffAddress.Length == 0)
            {
                //record the error
                Error = Error + "the staff address may not be blank : ";
            }
            //if the staff address is greater than 50 characters
            if (staffAddress.Length > 50)
            {
                //record the error
                Error = Error + "The staff address must be less than 50 characters : ";
            }
            if (staffTelNumber.Length == 0)
            {
                //record the error
                Error = Error + "The staff telephone number may not be blank : ";
            }
            //if the staffTelnumber is greater than 50 characters
            if (staffTelNumber.Length > 11)
            {
                //record the error
                Error = Error + "The staff telephone number must be less than 12 characters : ";
            }

            try
            {
                //copy the datejoined value to the datetemp variable
                IntTemp = Convert.ToInt32(staffID);
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
                Error = Error + "The record was not a valid record";
            }
            


            //return any error messages           
            return Error;
        }
    }

}