﻿using System;

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
            //set the priavate data members to test data with
            mModelNo = 21;
            mDateAdded = Convert.ToDateTime("16/9/2015");
            mCarModel = "Test Car";
            mBHP = "532";
            mPrice = 1;
            mAvailability = true;

            //always return true
            return true;
        }
    }
}