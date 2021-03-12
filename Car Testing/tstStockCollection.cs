using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using CarClasses;

namespace Car_Testing
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //test to see that it exsissts
            Assert.IsNotNull(AllStocks);
        }

        [TestMethod]
        public void StockListOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //create some test data to assign to the proeprty
            //in this case the data needs to be list of object
            List<clsStock> TestList = new List<clsStock>();
            //add an item to the list
            //create the item of the test data
            clsStock TestItem = new clsStock();
            //set its propertties
            TestItem.Availability = true;
            TestItem.CarModel = "Mercedes A Class";
            TestItem.BHP = "120 BHP";
            TestItem.Price = 1;
            TestItem.DateAdded = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the properly
            AllStocks.StockList = TestList;
            //test to see the two values are the same
            Assert.AreEqual(AllStocks.StockList, TestList);

        }


        [TestMethod]
        public void ThisStockPropertyOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //create to some test data to assign to the property
            clsStock TestStock = new clsStock();
            //set the properties of the test object
            TestStock.Availability = true;
            TestStock.CarModel = "Mercedes A Class";
            TestStock.BHP = "120 BHP";
            TestStock.Price = 1;
            TestStock.DateAdded = DateTime.Now.Date;
            //asign the data to the proerpty
            AllStocks.ThisStock = TestStock;
            //test to see thew two values are the same
            Assert.AreEqual(AllStocks.ThisStock, TestStock);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //crewate in stance of the class
            clsStockCollection AllStocks = new clsStockCollection();
            //creat some test data 
            List<clsStock> TestList = new List<clsStock>();
            //add an item to the list
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.Availability = true;
            TestItem.CarModel = "Mercedes A Class";
            TestItem.BHP = "120 BHP";
            TestItem.Price = 1;
            TestItem.DateAdded = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the daft to the proerty
            AllStocks.StockList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStocks.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an nstance for theclass we want to screate
            clsStockCollection AllStocks = new clsStockCollection();
            //create the item of test data
            clsStock TestItem = new clsStock();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Availability = true;
            TestItem.CarModel = "Mercedes A Class Test ADD function";
            TestItem.BHP = "420 BHP";
            TestItem.Price = 1;
            TestItem.DateAdded = DateTime.Now.Date;
            //Setup the his address to test data
            AllStocks.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStocks.Add();
            //find the record
            AllStocks.ThisStock.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStocks.ThisStock, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //create the item of the test data
            clsStock TestItem = new clsStock();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Availability = true;
            TestItem.CarModel = "Mercedes A Class Test ADD function";
            TestItem.BHP = "420 BHP";
            TestItem.Price = 1;
            TestItem.DateAdded = DateTime.Now.Date;
            //set this address to the test data
            AllStocks.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStocks.Add();
            //set the pimrary key of the test date
            TestItem.ModelNo = PrimaryKey;
            //find the record
            AllStocks.ThisStock.Find(PrimaryKey);
            //delete the record
            AllStocks.Delete();
            //now find the record
            Boolean Found = AllStocks.ThisStock.Find(PrimaryKey);
            //test to see that te record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //create the item of the test data
            clsStock TestItem = new clsStock();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Availability = true;
            TestItem.CarModel = "Mercedes A Class Test ADD function";
            TestItem.BHP = "420 BHP";
            TestItem.Price = 1;
            TestItem.DateAdded = DateTime.Now.Date;
            //set this address to the test data
            AllStocks.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStocks.Add();
            //set the pimrary key of the test date
            TestItem.ModelNo = PrimaryKey;
            //modify test data
            TestItem.Availability = false;
            TestItem.CarModel = "Mercedes A Class Test ADD function";
            TestItem.BHP = "420 BHP";
            TestItem.Price = 1;
            TestItem.DateAdded = DateTime.Now.Date;
            //set the record based on the new test data
            AllStocks.ThisStock = TestItem;
            //update the record
            AllStocks.Update();
            //find the record
            AllStocks.ThisStock.Find(PrimaryKey);
            //test to see this stock matches the test data
            Assert.AreEqual(AllStocks.ThisStock, TestItem);
        }

        [TestMethod]
        public void ReportByCarModelMethodOK()
        {
            //create an instance of the class containing unflitered results
            clsStockCollection AllStocks = new clsStockCollection();
            //create an instance of the filtered data
            clsStockCollection FilteredStocks = new clsStockCollection();
            //apply a bank string (should return all records);
            FilteredStocks.ReportByCarModel("");
            //test to see that the two values are the same
            Assert.AreEqual(AllStocks.Count, FilteredStocks.Count);
        }

        [TestMethod]
        public void ReportByCarModelNoneFound()
        {
            clsStockCollection FilteredStocks = new clsStockCollection();
            //apply for a car model that dont exsist
            FilteredStocks.ReportByCarModel("xxxxxxxx x xxx");
            //test t o see that there are no records
            Assert.AreEqual(0, FilteredStocks.Count);
        }

        [TestMethod]
        public void ReportByPostCodeTestDataFound()
        {
            //create an insatcne of the filrted data
            clsStockCollection FilteredStocks = new clsStockCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a post code that doesnt exist
            FilteredStocks.ReportByCarModel("xxxxxxx x xxxx");
            //check that the correct number of records are found
            if (FilteredStocks.Count == 2)
            {
                //check that the first record is ID 36
                if (FilteredStocks.StockList[0].ModelNo != 149)
                {
                    OK = false;
                }
                //check that the first record is ID 150
                if (FilteredStocks.StockList[1].ModelNo != 150)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }

    }
}
