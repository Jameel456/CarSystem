using System;

namespace CarClasses
{
    public class clsStock
    {
        //private data member for Availability
        private Boolean mAvailability;
        //public property for Availability
        public bool Availability
        {
            get
            {
                //return the private data
                return mAvailability;
            }
            set
            {
                //set the private data
                mAvailability = value;
            }
        }


        //private data member for the model no property
        private Int32 mModelNo;
        //model no public property 
        public Int32 ModelNo
        {
            get
            {
                //this line of code sends out the data of the proeprt
                return mModelNo;
            }
            set
            {
                //this line of code allowes data into theporerpty
                mModelNo = value;
            }
        }

        //private data member for the model no property
        private DateTime mDateAdded;
        //model no public property 
        public DateTime DateAdded
        {
            get
            {
                //this line of code sends out the data of the proeprt
                return mDateAdded;
            }
            set
            {
                //this line of code allowes data into theporerpty
                mDateAdded = value;
            }
        }

        //private data member for CarModel
        private string mCarModel;
        //public property for house no
        public string CarModel
        {
            get
            {
                //return private data
                return mCarModel;
            }
            set
            {
                //set the private data
                mCarModel = value;
            }
        }


        //private data member for county no
        private Int32 mPrice;
        //public property for county no
        public int Price
        {
            get
            {
                //return the private data
                return mPrice;
            }
            set
            {
                //set the private data
                mPrice = value;
            }
        }

        //private data member for BHP
        private string mBHP;
        //public property for house no
        public string BHP
        {
            get
            {
                //return private data
                return mBHP;
            }
            set
            {
                //set the private data
                mBHP = value;
            }
        }


        public bool Find(int modelNo)
        {
            //create an instance for the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the paremter for the address not o search for
            DB.AddParameter("@ModelNo", modelNo);
            //execture the stored procedure
            DB.Execute("sproc_tblStock_FilterByModelNo");
            //if one record is found (theres hould be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the data bacse to the private data members
                mModelNo = Convert.ToInt32(DB.DataTable.Rows[0]["ModelNo"]);
                mCarModel = Convert.ToString(DB.DataTable.Rows[0]["CarModel"]);
                mBHP = Convert.ToString(DB.DataTable.Rows[0]["BHP"]);
                mPrice = Convert.ToInt32(DB.DataTable.Rows[0]["Price"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mAvailability = Convert.ToBoolean(DB.DataTable.Rows[0]["Availability"]);
                //return everything worked ok
                return true;
            }
            //if no record was found then
            else
            {
                //return false indicating a problem 
                return false;
            }
        }

        public string Valid(string carModel, string bHP, int price, string dateAdded)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary varibale to store datat values
            DateTime DateTemp;
            //this sees if the string is less than 1 or more than 10000000
            if (price < 1 | price > 100000000)
            {
                //records the error
                Error = Error + "The price number must be between 1 and 100 MILLION : ";
            }

            try
            {
                Int32 Temp;
                Temp = Convert.ToInt32(price);
            }
            catch
            {
                Error = Error + "The price must be a number : ";
            }

            //if the BHP is blank
            if (bHP.Length == 0)
            {
                //record error
                Error = Error + "The BHP may not be blank : ";
            }
            //if the bhp no is grewter than 6
            if (bHP.Length > 8)
            {
                //record the error
                Error = Error + "The BHP must be less than 8 characaters : ";
            }

            if (carModel.Length == 0)
            {
                //record error
                Error = Error + "The Car Model may not be blank : ";
            }
            //if the bhp no is grewter than 6
            if (carModel.Length > 50)
            {
                //record the error
                Error = Error + "The Car Model must be less than 8 characaters : ";
            }

            try
            {
                //copy the date added value to the datetemp variable
                DateTemp = Convert.ToDateTime(dateAdded);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past : ";
                }

                //check to see if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was no a valid date : ";
            }

            //return error messages
            return Error;
        }
    }
}