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

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create an item of test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set it's properties 
            TestItem.Active = true;
            TestItem.StaffID = 1;
            TestItem.StaffName = "Hamzah";
            TestItem.StaffAddress = "1 Leicester Road";
            TestItem.StaffTelNumber = "07871740971";
            TestItem.DateJoined = DateTime.Now.Date;
            //assign the data to the property
            AllStaff.ThisStaff = TestItem;
            //find the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.StaffID = PrimaryKey;
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create an item of test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set it's properties 
            TestItem.Active = true;
            TestItem.StaffID = 1;
            TestItem.StaffName = "Hamzah";
            TestItem.StaffAddress = "1 Leicester Road";
            TestItem.StaffTelNumber = "07871740971";
            TestItem.DateJoined = DateTime.Now.Date;
            //assign the data to the property
            AllStaff.ThisStaff = TestItem;
            //find the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.StaffID = PrimaryKey;
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //delete the record
            AllStaff.Delete();
            //now find the record
            Boolean Found = AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create an item of test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set it's properties 
            TestItem.Active = true;
            TestItem.StaffID = 1;
            TestItem.StaffName = "Hamzah";
            TestItem.StaffAddress = "1 Leicester Road";
            TestItem.StaffTelNumber = "07871740971";
            TestItem.DateJoined = DateTime.Now.Date;
            //assign the data to the property
            AllStaff.ThisStaff = TestItem;
            //find the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.StaffID = PrimaryKey;
            //modify the test data
            TestItem.Active = false;
            TestItem.StaffID = 3;
            TestItem.StaffName = "Jameel";
            TestItem.StaffAddress = "2 Manchester Road";
            TestItem.StaffTelNumber = "07871740974";
            TestItem.DateJoined = DateTime.Now.Date;
            //set the record based on the new test data
            AllStaff.ThisStaff = TestItem;
            //update the record
            AllStaff.Update();
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

        [TestMethod]

        public void ReportByStaffNameMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create an instance of the filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //apply a blank string (should return all records);
            FilteredStaff.ReportByStaffName("");
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, FilteredStaff.Count);
        }

        [TestMethod]

        public void ReportByStaffNameNoneFound()
        {
            //create an instance of the filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //apply a post code that doesn't exist
            FilteredStaff.ReportByStaffName("xxx xxx");
            //test to see thats there are no records
            Assert.AreEqual(0, FilteredStaff.Count);
        }

        [TestMethod]

        public void ReportByStaffNameTestDataFound()
        {
            //create an instance of the filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a post code that doesn't exist
            FilteredStaff.ReportByStaffName("yyy yyy");
            //check that the correct number of records are found
            if (FilteredStaff.Count == 2)
            {
                //check that the first record is ID 36
                if (FilteredStaff.StaffList[0].StaffID != 41)
                {
                    OK = false;
                }
                //check that the first record is ID 37
                if (FilteredStaff.StaffList[1].StaffID != 42)
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
