using System;
using CarClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Car_Testing
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //test to see that it exsists
            Assert.IsNotNull(AStock);
        }

        [TestMethod]
        public void AvailabilityStockOK()
        {
            //create and instance of the classs we want to create
            clsStock AStock = new clsStock();
            //crewate a some test data to assing to the porpertt
            Boolean TestData = true;
            //assign the data to the property
            AStock.Availability = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.Availability, TestData);
        }

        [TestMethod]
        public void DateAddedStockOK()
        {
            //create an instance for the class
            clsStock AStock = new clsStock();
            //creat some test data to assign the proeprtly
            DateTime TestData = DateTime.Now.Date;
            //asignt the data to the proerty
            AStock.DateAdded = TestData;
            //test to see that both values are the dame
            Assert.AreEqual(AStock.DateAdded, TestData);
        }

        [TestMethod]
        public void ModelNoStockOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AStock.ModelNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.ModelNo, TestData);
        }

        [TestMethod]
        public void BHPStockOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            string TestData = "100 BHP";
            //assign the data to the property
            AStock.BHP = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.BHP, TestData);
        }

        [TestMethod]
        public void PriceStockOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AStock.Price = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.Price, TestData);
        }

        [TestMethod]
        public void CarModelOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            string TestData = "Mercedes Benz C Class Coupe Premium";
            //assign the data to the property
            AStock.CarModel = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.CarModel, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the results of the validartion
            Boolean Found = false;
            //create some test data for the method
            Int32 ModelNo = 23;
            //invoke the method
            Found = AStock.Find(ModelNo);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStockNoFound()
        {
            //create an instance for the classs
            clsStock AStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variablto record if the data is ok (assume it is ok)
            Boolean OK = true;
            //create some test data for the method
            Int32 ModelNo = 21;
            //invokeing the method
            Found = AStock.Find(ModelNo);
            //check the address no
            if (AStock.ModelNo != 21)
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCarModelFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ModelNo = 21;
            //invoke the method
            Found = AStock.Find(ModelNo);
            //check the property
            if (AStock.CarModel != "Test Car")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestBHPFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ModelNo = 21;
            //invoke the method
            Found = AStock.Find(ModelNo);
            //check the property
            if (AStock.BHP != "532")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPriceFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ModelNo = 21;
            //invoke the method
            Found = AStock.Find(ModelNo);
            //check the property
            if (AStock.Price != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAvailabilityFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ModelNo = 21;
            //invoke the method
            Found = AStock.Find(ModelNo);
            //check the property
            if (AStock.Availability != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is}
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ModelNo = 21;
            //invoke the method
            Found = AStock.Find(ModelNo);
            //check the property
            if (AStock.DateAdded != Convert.ToDateTime("16/09/2015"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

    }
}




