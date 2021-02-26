using System;
using CarClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Car_Testing
{
    [TestClass]
    public class tstStock
    {
       
            //good test data
            //create some test data to pass to the method
            string CarModel = "Test Car";
            string BHP = "500 BHP";
            Int32 Price = 100000;
            string DateAdded = DateTime.Now.Date.ToString();
        
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
            Boolean Found = true;
            //create some test data for the method
            Int32 ModelNo = 1;
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
            Int32 ModelNo = 1;
            //invokeing the method
            Found = AStock.Find(ModelNo);
            //check the address no
            if (AStock.ModelNo != 1)
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
            Int32 ModelNo = 1;
            //invoke the method
            Found = AStock.Find(ModelNo);
            //check the property
            if (AStock.CarModel != "Mercedes A Class")
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
            Int32 ModelNo = 1;
            //invoke the method
            Found = AStock.Find(ModelNo);
            //check the property
            if (AStock.BHP != "120 BHP")
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
            Int32 ModelNo = 1;
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
            Int32 ModelNo = 1;
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
            Int32 ModelNo = 1;
            //invoke the method
            Found = AStock.Find(ModelNo);
            //check the property
            if (AStock.DateAdded != Convert.ToDateTime("16/02/2019 00:00:00"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //invoke method
            Error = AStock.Valid(CarModel, BHP, Price, DateAdded);
            //test to see that results is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BHPMinLessOne()
        {
            //create an instance of the classw e want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            String BHP = ""; // this should trigger the error
            //invoke the method
            Error = AStock.Valid(CarModel, BHP, Price, DateAdded);
            //test to see that the reult is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BHPMin()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string BHP = "a"; //this should be ok
            //invoke the method
            Error = AStock.Valid(CarModel, BHP, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BHPMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string BHP = "aa"; //this should be ok
            //invoke the method
            Error = AStock.Valid(CarModel, BHP, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BHPMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string BHP = "aaaaaaa"; //this should be ok
            //invoke the method
            Error = AStock.Valid(CarModel, BHP, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void BHPMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string BHP = "aaaaaaaa"; //this should be ok
            //invoke the method
            Error = AStock.Valid(CarModel, BHP, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BHPMid()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string BHP = "aaaa"; //this should be ok
           //invoke the method
            Error = AStock.Valid(CarModel, BHP, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BHPMaxPlusOne()
        {
            //create an instance of the classs we want ot create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to passs the method
            string BHP = "aaaaaaaaa"; //this should fail
            //invoke the method
            Error = AStock.Valid(CarModel, BHP, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BHPExtremeMax()
        {
            //create an instance of the classs we want ot create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to passs the method
            string BHP = "";
            BHP = BHP.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AStock.Valid(CarModel, BHP, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variablet store any error messafe
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            Error = AStock.Valid(CarModel, BHP, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AStock.Valid(CarModel, BHP, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AStock.Valid(CarModel, BHP, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AStock.Valid(CarModel, BHP, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AStock.Valid(CarModel, BHP, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedInvalidData()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //set the datadded toa non date value
            string DateAdded = "this is not a date!";
            //invoke the method
            Error = AStock.Valid(CarModel, BHP, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CarModelMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string CarModel = "";
            //invoke the method
            Error = AStock.Valid(CarModel, BHP, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CarModelMin()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CarModel = "a";
            //invoke the method
            Error = AStock.Valid(CarModel, BHP, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CarModelMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CarModel = "aa";
            //invoke the method
            Error = AStock.Valid(CarModel, BHP, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CarModelMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CarModel = "";
            CarModel = CarModel.PadRight(49, 'a');
            //invoke the method
            Error = AStock.Valid(CarModel, BHP, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CarModelMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CarModel = "";
            CarModel = CarModel.PadRight(50, 'a');
            //invoke the method
            Error = AStock.Valid(CarModel, BHP, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CarModelMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string CarModel = "";
            //invoke the method
            Error = AStock.Valid(CarModel, BHP, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CarModelMid()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CarModel = "";
            CarModel = CarModel.PadRight(25, 'a');
            //invoke the method
            Error = AStock.Valid(CarModel, BHP, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            Int32 Price = 0;
            //invoke the method
            Error = AStock.Valid(CarModel, BHP, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceModelMin()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            Int32 Price = 1;
            //invoke the method
            Error = AStock.Valid(CarModel, BHP, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            Int32 Price = 2;
            //invoke the method
            Error = AStock.Valid(CarModel, BHP, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            Int32 Price = 99999998;
            //invoke the method
            Error = AStock.Valid(CarModel, BHP, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            Int32 Price = 99999999;
            //invoke the method
            Error = AStock.Valid(CarModel, BHP, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            Int32 Price = 100000000;
            //invoke the method
            Error = AStock.Valid(CarModel, BHP, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMid()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            Int32 Price = 500000;
            //invoke the method
            Error = AStock.Valid(CarModel, BHP, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

    }
}




