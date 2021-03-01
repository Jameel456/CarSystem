using System;
using CarClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Car_Testing
{ 



    [TestClass]
    public class tstStaff
    {
        //good test data
        //create some test data to pass to the method
        string StaffName = "Hamzah";
        string StaffAddress = "1 Leicester Road";
        string StaffTelNumber = "0787172872";
        string DateJoined = DateTime.Now.Date.ToString();



        [TestMethod]

        public void InstanceOk()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(AStaff);
        }

        [TestMethod]
        public void ActiveStaffOk()
        {
            //create an instance of the class we want 
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the staff
            Boolean TestData = true;
            //assing the data to the staff member
            AStaff.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Active, TestData);
        }

        [TestMethod]
        public void ActiveDateJoinedOK()
        {
            //create an instance of th class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the staff
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AStaff.DateJoined = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.DateJoined, TestData);
        }

        [TestMethod]
        public void StaffIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AStaff.StaffID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffID, TestData);
        }

        [TestMethod]
        public void StaffAddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            String TestData = "1 Leicester Road";
            //assign the data to the property
            AStaff.StaffAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffAddress, TestData);
        }

        [TestMethod]
        public void StaffTelNumberPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "07871737893";
            //assign the data to the property
            AStaff.StaffTelNumber = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffTelNumber, TestData);
        }

        [TestMethod]
        public void StaffNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            String TestData = "Hamzah";
            //assign the data to the property
            AStaff.StaffName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffName, TestData);
        }

        [TestMethod]

        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 StaffID = 1;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStaffIDFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 1;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the staff id
            if (AStaff.StaffID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateJoinedFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 1;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the staff id
            if (AStaff.DateJoined != Convert.ToDateTime("18/08/1991"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffNameFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 1;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the staff id
            if (AStaff.StaffName != "Hamzah")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffAddressFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 1;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the staff id
            if (AStaff.StaffAddress != "1 Leicester Road")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffTelNumberFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 1;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the staff id
            if (AStaff.StaffTelNumber != "07871740971")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestActiveFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 1;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the staff id
            if (AStaff.Active != true)
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
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffAddress, StaffTelNumber, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void StaffNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffName = ""; // this should trigger an error
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffAddress, StaffTelNumber, DateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        public void StaffNameNoMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffName = "H"; // this should trigger be ok
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffAddress, StaffTelNumber, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffName = "Ha"; // this should be ok
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffAddress, StaffTelNumber, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "a";
            //create some test data to pass to the method
            string StaffName = "Ha"; // this should be ok
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffAddress, StaffTelNumber, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffName = "0123456789012345678901234567890123456789012345678"; // this should be ok
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffAddress, StaffTelNumber, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffName = "01234567890123456789012345678901234567890123456789"; // this should be ok
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffAddress, StaffTelNumber, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffName = "0123456789012345678901234"; // this should be ok
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffAddress, StaffTelNumber, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffName = "012345678901234567890123456789012345678901234567890"; // this should be ok
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffAddress, StaffTelNumber, DateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffName = "";
            StaffName = StaffName.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffAddress, StaffTelNumber, DateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        // DATEJOINED PARAMETER

        [TestMethod]
        
        public void DateJoinedExtremeMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date variable to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string DateJoined = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffAddress, StaffTelNumber, DateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]

        public void DateJoinedMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store the test date data
            String Error = "";
            //creating a variable to store the test date data 
            DateTime TestDate;
            //set the to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variabl to a string variable
            string DateJoined = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffAddress, StaffTelNumber, DateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateJoinedMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff ();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateJoined = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffAddress, StaffTelNumber, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateJoinedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateJoined = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffAddress, StaffTelNumber, DateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateJoinedExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(100);
            //convert the date variable to a string variable
            string DateJoined = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffAddress, StaffTelNumber, DateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]

        public void DateJoinedInvalidData()
        {
            //create an instance of the class we want to create 
            clsStaff AStaff = new clsStaff();
            //string varaibel to store any error message
            String Error = "";
            //set the DateJoine to a non date value
            string DateJoined = "this is not a date";
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffAddress, StaffTelNumber, DateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffAddressNoMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string varaible to store the results of the validation
            String Error = "";
            //create some test data to pass to the method
            string StaffAddress = "a";
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffAddress, StaffTelNumber, DateJoined);
            //test to see if the results is true
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void StaffAddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string varaible to store the results of the validation
            String Error = "";
            //create some test data to pass to the method
            string StaffAddress = "aa";
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffAddress, StaffTelNumber, DateJoined);
            //test to see if the results is true
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void StaffAddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string varaible to store the results of the validation
            String Error = "";
            //create some test data to pass to the method
            string StaffAddress = "";
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffAddress, StaffTelNumber, DateJoined);
            //test to see if the results is true
            Assert.AreNotEqual(Error, "");

        }


        public void StaffAddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string varaible to store the results of the validation
            String Error = "";
            //create some test data to pass to the method
            string StaffAddress = "0123456789012345678901234567890123456789012345678";
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffAddress, StaffTelNumber, DateJoined);
            //test to see if the results is true
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void StaffAddressMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string varaible to store the results of the validation
            String Error = "";
            //create some test data to pass to the method
            string StaffAddress = "01234567890123456789012345678901234567890123456789";
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffAddress, StaffTelNumber, DateJoined);
            //test to see if the results is true
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void StaffAddressMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string varaible to store the results of the validation
            String Error = "";
            //create some test data to pass to the method
            string StaffAddress = "0123456789012345678901234";
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffAddress, StaffTelNumber, DateJoined);
            //test to see if the results is true
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void StaffAddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string varaible to store the results of the validation
            String Error = "";
            //create some test data to pass to the method
            string StaffAddress = "012345678901234567890123456789012345678901234567890";
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffAddress, StaffTelNumber, DateJoined);
            //test to see if the results is true
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void StaffAddressExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string varaible to store the results of the validation
            String Error = "";
            //create some test data to pass to the method
            string StaffAddress = "";
            StaffAddress = StaffAddress.PadRight(500, 'a');
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffAddress, StaffTelNumber, DateJoined);
            //test to see if the results is true
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void StaffTelNumberMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string varaible to store the results of the validation
            String Error = "";
            //create some test data to pass to the method
            string StaffTelNumber = "";
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffAddress, StaffTelNumber, DateJoined);
            //test to see if the results is true
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void StaffTelNumberNoMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string varaible to store the results of the validation
            String Error = "";
            //create some test data to pass to the method
            string StaffTelNumber = "a";
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffAddress, StaffTelNumber, DateJoined);
            //test to see if the results is true
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void StaffTelNumberPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string varaible to store the results of the validation
            String Error = "";
            //create some test data to pass to the method
            string StaffTelNumber = "aa";
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffAddress, StaffTelNumber, DateJoined);
            //test to see if the results is true
            Assert.AreEqual(Error, "");

        }

        public void StaffTelNumberMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string varaible to store the results of the validation
            String Error = "";
            //create some test data to pass to the method
            string StaffTelNumber = "0123456789";
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffAddress, StaffTelNumber, DateJoined);
            //test to see if the results is true
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void StaffTelNumberMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string varaible to store the results of the validation
            String Error = "";
            //create some test data to pass to the method
            string StaffTelNumber = "01234567890";
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffAddress, StaffTelNumber, DateJoined);
            //test to see if the results is true
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void StaffTelNumberMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string varaible to store the results of the validation
            String Error = "";
            //create some test data to pass to the method
            string StaffTelNumber = "0123454";
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffAddress, StaffTelNumber, DateJoined);
            //test to see if the results is true
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void StaffTelNumberMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string varaible to store the results of the validation
            String Error = "";
            //create some test data to pass to the method
            string StaffTelNumber = "0123456789012";
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffAddress, StaffTelNumber, DateJoined);
            //test to see if the results is true
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void StaffTelNumberExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string varaible to store the results of the validation
            String Error = "";
            //create some test data to pass to the method
            string StaffTelNumber = "";
            StaffTelNumber = StaffTelNumber.PadRight(500, 'a');
            //invoke the method
            Error = AStaff.Valid(StaffName, StaffAddress, StaffTelNumber, DateJoined);
            //test to see if the results is true
            Assert.AreNotEqual(Error, "");

        }


    }
}

