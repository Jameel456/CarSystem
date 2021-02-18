using System;

namespace CarClasses
{
    public class clsCustomer
    {
        public bool Active { get; set; }
        public DateTime DateJoined { get; set; }
        public int CustomerID { get; set; }
        public string CustomerTelNumber { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerName { get; set; }
    }
}