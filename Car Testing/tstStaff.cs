using System;
using CarClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Car_Testing
{
    [TestClass]
    public class tstStaff
    {
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



    }

}
