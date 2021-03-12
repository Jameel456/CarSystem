using System;
using CarClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Car_Testing
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see that it existt
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.Active = true;
            TestItem.CustomerID = 1;
            TestItem.CustomerName = "Jeff Adams";
            TestItem.CustomerTelNumber = "07896432654";
            TestItem.CustomerAddress = "45 Leicester Street";
            TestItem.DateJoined = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }




        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            //create the item of test data
            clsCustomer TestCustomer = new clsCustomer();
            //set its properties
            TestCustomer.Active = true;
            TestCustomer.CustomerID = 1;
            TestCustomer.CustomerName = "Jeff Adams";
            TestCustomer.CustomerTelNumber = "07896432654";
            TestCustomer.CustomerAddress = "45 Leicester Street";
            TestCustomer.DateJoined = DateTime.Now.Date;
            //assign the data to the property
            AllCustomers.ThisCustomer = TestCustomer;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);

        }


        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.Active = true;
            TestItem.CustomerID = 1;
            TestItem.CustomerName = "Jeff Adams";
            TestItem.CustomerTelNumber = "07896432654";
            TestItem.CustomerAddress = "45 Leicester Street";
            TestItem.DateJoined = DateTime.Now.Date;
            //add the item to the test list 
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, TestList.Count);

        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.CustomerID = 1;
            TestItem.CustomerName = "Jeff Adams";
            TestItem.CustomerTelNumber = "07896432654";
            TestItem.CustomerAddress = "45 Leicester Street";
            TestItem.DateJoined = DateTime.Now.Date;
            //set thisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            // set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);

        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.CustomerID = 1;
            TestItem.CustomerName = "Jeff Adams";
            TestItem.CustomerTelNumber = "07896432654";
            TestItem.CustomerAddress = "45 Leicester Street";
            TestItem.DateJoined = DateTime.Now.Date;
            //set thisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            // set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //delete the record
            AllCustomers.Delete();
            //now find the record
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);


        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an insatnce of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.CustomerID = 1;
            TestItem.CustomerName = "Jeff Adams";
            TestItem.CustomerTelNumber = "07896432654";
            TestItem.CustomerAddress = "45 Leicester Street";
            TestItem.DateJoined = DateTime.Now.Date;
            //set thisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data 
            TestItem.CustomerID = PrimaryKey;
            //modify the test data
            TestItem.Active = false;
            TestItem.CustomerID = 6;
            TestItem.CustomerName = "Alam Patel";
            TestItem.CustomerTelNumber = "07896432774";
            TestItem.CustomerAddress = "95 Buckingham Street";
            TestItem.DateJoined = DateTime.Now.Date;
            //set the record based on the new test data
            AllCustomers.ThisCustomer = TestItem;
            //update the record
            AllCustomers.Update();
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see if thisCustomer matches the testdata
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);


        }

        [TestMethod]
        public void ReportbyCustomerName()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomerName = new clsCustomerCollection();
            //apply a blank string (should return all record);
            FilteredCustomerName.ReportByCustomerName("");
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, FilteredCustomerName.Count);
        }

        [TestMethod]
        public void ReportbyCustomerNameNoneFound()
        {

            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomerName = new clsCustomerCollection();
            //test to see that the are no records;
            FilteredCustomerName.ReportByCustomerName("xxx xxx");
            //test to see that the two values are the same
            Assert.AreEqual(0, FilteredCustomerName.Count);
        }

        [TestMethod]
        public void ReportbyCustomerNameTestDataFound()
        {

            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomerName = new clsCustomerCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a customer name that doesnt exist
            FilteredCustomerName.ReportByCustomerName("yyy yyy");
            //check that the correct number of records are found
            if (FilteredCustomerName.Count == 2)
            {
                {
                    OK = false;

                }
                //check that the first record is ID 37
                if (FilteredCustomerName.CustomerList[0].CustomerID != 8)
                {
                    OK = false;
                }
                //check that the first record is ID 37
                if (FilteredCustomerName.CustomerList[1].CustomerID != 9)
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
