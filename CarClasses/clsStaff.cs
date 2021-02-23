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

       
    }

}