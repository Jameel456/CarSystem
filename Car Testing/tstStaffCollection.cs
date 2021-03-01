using System;
using CarClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Car_Testing
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //test to see tha it exsits
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]

        public void StaffListOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property 
            //in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties 
            TestItem.Active = true;
            TestItem.StaffID = 1;
            TestItem.StaffName = "Hamzah";
            TestItem.StaffAddress = "1 Leicester Road";
            TestItem.StaffTelNumber = "07871740971";
            TestItem.DateJoined = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same 
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }

        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property 
            clsStaff TestStaff = new clsStaff();
            //set its properties 
            TestStaff.Active = true;
            TestStaff.StaffID = 1;
            TestStaff.StaffName = "Hamzah";
            TestStaff.StaffAddress = "1 Leicester Road";
            TestStaff.StaffTelNumber = "07871740971";
            TestStaff.DateJoined = DateTime.Now.Date;
            //assign the data to the property
            AllStaff.ThisStaff = TestStaff;
            //test to see that the two values are the same 
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assing to the staff
            //in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list 
            //create the item of test data 
            clsStaff TestItem = new clsStaff();
            //set it properties
            TestItem.Active = true;
            TestItem.StaffID = 1;
            TestItem.StaffName = "Hamzah";
            TestItem.StaffAddress = "1 Leicester Road";
            TestItem.StaffTelNumber = "07871740971";
            TestItem.DateJoined = DateTime.Now.Date;
            //assign the data to the property
            TestList.Add(TestItem);
            //assign the data to the property 
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, TestList.Count);

        }

    }
    }
