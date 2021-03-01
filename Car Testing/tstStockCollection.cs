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
            TestItem.ModelNo = 1;
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
            TestStock.ModelNo = 1;
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
            TestItem.ModelNo = 1;
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
      

    }
}
