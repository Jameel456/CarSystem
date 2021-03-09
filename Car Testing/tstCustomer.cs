using System;
using CarClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Car_Testing
{
    [TestClass]


    public class tstCustomer
    {
        //good test data
        //create some test data to pass to the method
        string CustomerID = 1.ToString();
        string CustomerName = "Jeff Adams";
        string CustomerAddress = "45 Leicester Street";
        string CustomerTelNumber = "07896432654";
        string DateJoined = DateTime.Now.Date.ToString();

       

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //test to xee that it exists
            Assert.IsNotNull(ACustomer);
        }
        [TestMethod]
        public void ActiveCustomerOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            ACustomer.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Active, TestData);


        }
        [TestMethod]
        public void DateJoinedCustomerOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            ACustomer.DateJoined = TestData;
            //test to see the two values are the same
            Assert.AreEqual(ACustomer.DateJoined, TestData);
        }
        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            ACustomer.CustomerID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerID, TestData);
        }
        [TestMethod]
        public void CustomerTelNumberPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "07093451874";
            //assign the data to the property
            ACustomer.CustomerTelNumber = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerTelNumber, TestData);
        }
        [TestMethod]
        public void CustomerAddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "32 London Road";
            //assign the data to the property
            ACustomer.CustomerAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerAddress, TestData);
        }
        [TestMethod]
        public void CustomerNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Adam Smith";
            //assign the data to the property
            ACustomer.CustomerName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerName, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean varaible to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 CustomerID = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //test to see if the results is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean varaible to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the customer id
            if (ACustomer.CustomerID != 1)
            {
                OK = false;
            }
            //test to see if the results is true
            Assert.IsTrue(OK);

        }

     

        [TestMethod]
        public void TestDateJoinedFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean varaible to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the customer id
            if (ACustomer.DateJoined != Convert.ToDateTime("12/02/2020"))
            {
                OK = false;
            }
            //test to see if the results is true
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestCustomerNameFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean varaible to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the customer id
            if (ACustomer.CustomerName != "Jeff Adams")
            {
                OK = false;
            }
            //test to see if the results is true
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestCustomerTelNumberFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean varaible to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the customer id
            if (ACustomer.CustomerTelNumber != "07896432654")
            {
                OK = false;
            }
            //test to see if the results is true
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestCustomerAddressFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean varaible to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the customer id
            if (ACustomer.CustomerAddress != "45 Leicester Street")
            {
                OK = false;
            }
            //test to see if the results is true
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestActiveFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean varaible to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the customer id
            if (ACustomer.Active != true)
            {
                OK = false;
            }
            //test to see if the results is true
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string varaible to store the results of the validation
            String Error = "";
            //invoke the method
            Error = ACustomer.Valid(CustomerID, CustomerName, CustomerTelNumber, CustomerAddress, DateJoined);
            //test to see if the results is true
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string varaible to store the results of the validation
            String Error = "";
            //create some test data to pass to the method
            string CustomerName = "";
            //invoke the method
            Error = ACustomer.Valid(CustomerID, CustomerName, CustomerTelNumber, CustomerAddress, DateJoined);
            //test to see if the results is true
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CustomerNameMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            
            //string varaible to store the results of the validation
            String Error = "";
            //create some test data to pass to the method
            string CustomerName = "a";
            //invoke the method
            Error = ACustomer.Valid(CustomerID, CustomerName, CustomerTelNumber, CustomerAddress, DateJoined);
            //test to see if the results is true
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string varaible to store the results of the validation
            String Error = "";
            //create some test data to pass to the method
            string CustomerName = "aa";
            //invoke the method
            Error = ACustomer.Valid(CustomerID, CustomerName, CustomerTelNumber, CustomerAddress, DateJoined);
            //test to see if the results is true
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string varaible to store the results of the validation
            String Error = "";
            //create some test data to pass to the method
            string CustomerName = "0123456789012345678901234567890123456789012345678";
            //invoke the method
            Error = ACustomer.Valid(CustomerID, CustomerName, CustomerTelNumber, CustomerAddress, DateJoined);
            //test to see if the results is true
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerNameMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string varaible to store the results of the validation
            String Error = "";
            //create some test data to pass to the method
            string CustomerName = "01234567890123456789012345678901234567890123456789";
            //invoke the method
            Error = ACustomer.Valid(CustomerID, CustomerName, CustomerTelNumber, CustomerAddress, DateJoined);
            //test to see if the results is true
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerNameMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string varaible to store the results of the validation
            String Error = "";
            //create some test data to pass to the method
            string CustomerName = "0123456789012345678901234";
            //invoke the method
            Error = ACustomer.Valid(CustomerID, CustomerName, CustomerTelNumber, CustomerAddress, DateJoined);
            //test to see if the results is true
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string varaible to store the results of the validation
            String Error = "";
            //create some test data to pass to the method
            string CustomerName = "012345678901234567890123456789012345678901234567890";
            //invoke the method
            Error = ACustomer.Valid(CustomerID, CustomerName, CustomerTelNumber, CustomerAddress, DateJoined);
            //test to see if the results is true
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CustomerNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string varaible to store the results of the validation
            String Error = "";
            //create some test data to pass to the method
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(500, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerID, CustomerName, CustomerTelNumber, CustomerAddress, DateJoined);
            //test to see if the results is true
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DateJoinedExtremeMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string varaible to store the results of the validation
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatver the date is less than 100 years 
            TestDate = TestDate.AddYears(-100);
            //Convert the date variable to string variable
            string DateJoined = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CustomerID, CustomerName, CustomerTelNumber, CustomerAddress, DateJoined);
            //test to see if the results is correct
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void DateJoinedMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string varaible to store the results of the validation
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatver the date is less than 100 years 
            TestDate = TestDate.AddDays(-1);
            //Convert the date variable to string variable
            string DateJoined = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CustomerID, CustomerName, CustomerTelNumber, CustomerAddress, DateJoined);
            //test to see if the results is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DateJoinedMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string varaible to store the results of the validation
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //Convert the date variable to string variable
            string DateJoined = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CustomerID, CustomerName, CustomerTelNumber, CustomerAddress, DateJoined);
            //test to see if the results is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void DateJoinedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string varaible to store the results of the validation
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //Convert the date variable to string variable
            string DateJoined = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CustomerID, CustomerName, CustomerTelNumber, CustomerAddress, DateJoined);
            //test to see if the results is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DateJoinedExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string varaible to store the results of the validation
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddYears(100);
            //Convert the date variable to string variable
            string DateJoined = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CustomerID, CustomerName, CustomerTelNumber, CustomerAddress, DateJoined);
            //test to see if the results is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DateJoinedInvalidDate()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string varaible to store the results of the validation
            String Error = "";
            //set the datejoined to a non date value
            string DateJoined = "this is not a date!";
            //invoke the method
            Error = ACustomer.Valid(CustomerID, CustomerName, CustomerTelNumber, CustomerAddress, DateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");


        }

        [TestMethod]
        public void CustomerAddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string varaible to store the results of the validation
            String Error = "";
            //create some test data to pass to the method
            string CustomerAddress = "";
            //invoke the method
            Error = ACustomer.Valid(CustomerID, CustomerName, CustomerTelNumber, CustomerAddress, DateJoined);
            //test to see if the results is true
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CustomerAddressMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string varaible to store the results of the validation
            String Error = "";
            //create some test data to pass to the method
            string CustomerAddress = "a";
            //invoke the method
            Error = ACustomer.Valid(CustomerID, CustomerName, CustomerTelNumber, CustomerAddress, DateJoined);
            //test to see if the results is true
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerAddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string varaible to store the results of the validation
            String Error = "";
            //create some test data to pass to the method
            string CustomerAddress = "aa";
            //invoke the method
            Error = ACustomer.Valid(CustomerID, CustomerName, CustomerTelNumber, CustomerAddress, DateJoined);
            //test to see if the results is true
            Assert.AreEqual(Error, "");

        }

        [TestMethod]

        public void CustomerAddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string varaible to store the results of the validation
            String Error = "";
            //create some test data to pass to the method
            string CustomerAddress = "0123456789012345678901234567890123456789012345678";
            //invoke the method
            Error = ACustomer.Valid(CustomerID, CustomerName, CustomerTelNumber, CustomerAddress, DateJoined);
            //test to see if the results is true
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerAddressMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string varaible to store the results of the validation
            String Error = "";
            //create some test data to pass to the method
            string CustomerAddress = "01234567890123456789012345678901234567890123456789";
            //invoke the method
            Error = ACustomer.Valid(CustomerID, CustomerName, CustomerTelNumber, CustomerAddress, DateJoined);
            //test to see if the results is true
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerAddressMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string varaible to store the results of the validation
            String Error = "";
            //create some test data to pass to the method
            string CustomerAddress = "0123456789012345678901234";
            //invoke the method
            Error = ACustomer.Valid(CustomerID, CustomerName, CustomerTelNumber, CustomerAddress, DateJoined);
            //test to see if the results is true
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerAddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string varaible to store the results of the validation
            String Error = "";
            //create some test data to pass to the method
            string CustomerAddress = "012345678901234567890123456789012345678901234567890";
            //invoke the method
            Error = ACustomer.Valid(CustomerID, CustomerName, CustomerTelNumber, CustomerAddress, DateJoined);
            //test to see if the results is true
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CustomerAddressExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string varaible to store the results of the validation
            String Error = "";
            //create some test data to pass to the method
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(500, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerID, CustomerName, CustomerTelNumber, CustomerAddress, DateJoined);
            //test to see if the results is true
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CustomerTelNumberMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string varaible to store the results of the validation
            String Error = "";
            //create some test data to pass to the method
            string CustomerTelNumber = "";
            //invoke the method
            Error = ACustomer.Valid(CustomerID, CustomerName, CustomerTelNumber, CustomerAddress, DateJoined);
            //test to see if the results is true
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CustomerTelNumberNoMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string varaible to store the results of the validation
            String Error = "";
            //create some test data to pass to the method
            string CustomerTelNumber = "a";
            //invoke the method
            Error = ACustomer.Valid(CustomerID, CustomerName, CustomerTelNumber, CustomerAddress, DateJoined);
            //test to see if the results is true
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerTelNumberPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string varaible to store the results of the validation
            String Error = "";
            //create some test data to pass to the method
            string CustomerTelNumber = "aa";
            //invoke the method
            Error = ACustomer.Valid(CustomerID, CustomerName, CustomerTelNumber, CustomerAddress, DateJoined);
            //test to see if the results is true
            Assert.AreEqual(Error, "");

        }

        public void CustomerTelNumberMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string varaible to store the results of the validation
            String Error = "";
            //create some test data to pass to the method
            string CustomerTelNumber = "01234567890";
            //invoke the method
            Error = ACustomer.Valid(CustomerID, CustomerName, CustomerTelNumber, CustomerAddress, DateJoined);
            //test to see if the results is true
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerTelNumberMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string varaible to store the results of the validation
            String Error = "";
            //create some test data to pass to the method
            string CustomerTelNumber = "01234567890";
            //invoke the method
            Error = ACustomer.Valid(CustomerID, CustomerName, CustomerTelNumber, CustomerAddress, DateJoined);
            //test to see if the results is true
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerTelNumberMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string varaible to store the results of the validation
            String Error = "";
            //create some test data to pass to the method
            string CustomerTelNumber = "0123454";
            //invoke the method
            Error = ACustomer.Valid(CustomerID, CustomerName, CustomerTelNumber, CustomerAddress, DateJoined);
            //test to see if the results is true
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CustomerTelNumberMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string varaible to store the results of the validation
            String Error = "";
            //create some test data to pass to the method
            string CustomerTelNumber = "0123456789012";
            //invoke the method
            Error = ACustomer.Valid(CustomerID, CustomerName, CustomerTelNumber, CustomerAddress, DateJoined);
            //test to see if the results is true
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CustomerTelNumberExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string varaible to store the results of the validation
            String Error = "";
            //create some test data to pass to the method
            string CustomerTelNumber = "";
            CustomerTelNumber = CustomerTelNumber.PadRight(500, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerID, CustomerName, CustomerTelNumber, CustomerAddress, DateJoined);
            //test to see if the results is true
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CustomerIDMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string CustomerID = "0";
            //invoke the method
            Error = ACustomer.Valid(CustomerID, CustomerName, CustomerTelNumber, CustomerAddress, DateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string CustomerID = "1" ;
            //invoke the method
            Error = ACustomer.Valid(CustomerID, CustomerName, CustomerTelNumber, CustomerAddress, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string CustomerID = "2";
            //invoke the method
            Error = ACustomer.Valid(CustomerID, CustomerName, CustomerTelNumber, CustomerAddress, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string CustomerID = "250";
            //invoke the method
            Error = ACustomer.Valid(CustomerID, CustomerName, CustomerTelNumber, CustomerAddress, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string CustomerID = "499";
            //invoke the method
            Error = ACustomer.Valid(CustomerID, CustomerName, CustomerTelNumber, CustomerAddress, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string CustomerID = "500";
            //invoke the method
            Error = ACustomer.Valid(CustomerID, CustomerName, CustomerTelNumber, CustomerAddress, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string CustomerID = "501";
            //invoke the method
            Error = ACustomer.Valid(CustomerID, CustomerName, CustomerTelNumber, CustomerAddress, DateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string CustomerID = "";
            CustomerID = CustomerID.PadRight(500, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerID, CustomerName, CustomerTelNumber, CustomerAddress, DateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}
