using System.Collections.Generic;
using System;
namespace CarClasses
{
    public class clsStockCollection
    {

        //private data member for the list
        List<clsStock> mStockList = new List<clsStock>();
        //provae data menber for this address
        clsStock mThisStock = new clsStock();

        public List<clsStock> StockList
        {
            get
            {
                //return the private data
                return mStockList;
            }
            set
            {
                //set the priavate data
                mStockList = value;
            }
        }

        public int Count
        {
            get
            {
                //return the private data
                return mStockList.Count;
            }
            set
            {
                //set the priavate data
            }
        }

       
        public clsStock ThisStock
        {
            get
            {
                //return the private data
                return mThisStock;
            }
            set
            {
                //set the private data
                mThisStock = value;
            }
        }

            
        public int Add()
        {
            //adds the new record to the database on the values of mThisStock
            //connects to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CarModel", mThisStock.CarModel);
            DB.AddParameter("@BHP", mThisStock.BHP);
            DB.AddParameter("@Price", mThisStock.Price);
            DB.AddParameter("@Availability", mThisStock.Availability);
            DB.AddParameter("@DateAdded", mThisStock.DateAdded);
            //execute the query returining the primary key value
            return DB.Execute("sproc_tblStock_Insert");
        }

        public void Delete()
        {
            //deletes the record poiinted to by this Stock
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedures
            DB.AddParameter("@ModelNo", mThisStock.ModelNo);
            //exectue the stored procedure
            DB.Execute("sproc_tblStock_Delete");
        }


        public int Update()
        {
            //adds the new record to the database on the values of mThisStock
            //connects to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@ModelNo", mThisStock.ModelNo);
            DB.AddParameter("@CarModel", mThisStock.CarModel);
            DB.AddParameter("@BHP", mThisStock.BHP);
            DB.AddParameter("@Price", mThisStock.Price);
            DB.AddParameter("@Availability", mThisStock.Availability);
            DB.AddParameter("@DateAdded", mThisStock.DateAdded);
            //execute the query returining the primary key value
            return DB.Execute("sproc_tblStock_Update");
        }


        //construtor for the class
        public clsStockCollection()
        {
            {
                //object for the data connection
                clsDataConnection DB = new clsDataConnection();
                //execute the stored procedure
                DB.Execute("sproc_tblStock_SelectAll");
                PopulateArray(DB);
            }
            //{
            //    //var for the indec
            //    Int32 Index = 0;
            //    //var to store the record count
            //    Int32 RecordCount = 0;
            //    //object for the data connection
            //    clsDataConnection DB = new clsDataConnection();
            //    //execute the stored procedure
            //    DB.Execute("sproc_tblStock_SelectAll");
            //    //get the count of records
            //    RecordCount = DB.Count;
            //    //while there are records to process
            //    while (Index < RecordCount)
            //    {
            //        //create a blank address
            //        clsStock AStock = new clsStock();
            //        //read inthe fiueld of the current record
            //        AStock.ModelNo = Convert.ToInt32(DB.DataTable.Rows[Index]["ModelNo"]);
            //        AStock.CarModel = Convert.ToString(DB.DataTable.Rows[Index]["CarModel"]);
            //        AStock.BHP = Convert.ToString(DB.DataTable.Rows[Index]["BHP"]);
            //        AStock.Price = Convert.ToInt32(DB.DataTable.Rows[Index]["Price"]);
            //        AStock.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
            //        AStock.Availability = Convert.ToBoolean(DB.DataTable.Rows[Index]["Availability"]);
            //        //add the record to the private data member
            //        mStockList.Add(AStock);
            //        //point at the next record
            //        Index++;
            //    }
            //    //create the item of test data
            //    clsStock TestItem = new clsStock();
            //    //set its properties
            //    TestItem.Availability = true;
            //    TestItem.ModelNo = 1;
            //    TestItem.CarModel = "Mercedes A Class";
            //    TestItem.BHP = "120 BHP";
            //    TestItem.Price = 1;
            //    TestItem.DateAdded = DateTime.Now.Date;
            //    //add the item to the test list
            //    mStockList.Add(TestItem);
            //    //resinitiadkoasdosmad
            //    TestItem = new clsStock();
            //    //set its properties
            //    TestItem.Availability = true;
            //    TestItem.ModelNo = 2;
            //    TestItem.CarModel = "Mercedes A45 AMG";
            //    TestItem.BHP = "290 BHP";
            //    TestItem.Price = 2;
            //    TestItem.DateAdded = DateTime.Now.Date;
            //    //add the item to the test list

            //    mStockList.Add(TestItem);
            //}
            
        }

        public void ReportByCarModel(string CarModel)
        {
            //filters the records based on a full or partial car model na,e
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the postcode parameter to the database
            DB.AddParameter("@CarModel", CarModel);
            //execute it
            DB.Execute("sproc_tblStock_FilterByCarModel");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populate the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of the records
            RecordCount = DB.Count;
            //creal the private array list
            mStockList = new List<clsStock>();
            //whiile there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsStock AStock = new clsStock();
                //read in the fields from the current record
                AStock.ModelNo = Convert.ToInt32(DB.DataTable.Rows[Index]["ModelNo"]);
                AStock.CarModel = Convert.ToString(DB.DataTable.Rows[Index]["CarModel"]);
                AStock.BHP = Convert.ToString(DB.DataTable.Rows[Index]["BHP"]);
                AStock.Price = Convert.ToInt32(DB.DataTable.Rows[Index]["Price"]);
                AStock.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                AStock.Availability = Convert.ToBoolean(DB.DataTable.Rows[Index]["Availability"]);
                //add the record to the private data member
                mStockList.Add(AStock);
                //point at the next record
                Index++;
            }
        }
    }



}