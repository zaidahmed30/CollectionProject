//using System;
//using System.Collections.Generic;

//namespace CollectionProject
//{
//    public class Customer
//    {
//        public int CustId { get; set; }
//        public string Name { get; set; }
//        public string City { get; set; }
//        public double Balance { get; set; }
//    }
//    public class TestCustomer
//    {
//        static void Main()
//        {
//            List<Customer> Customers = new List<Customer>();

//            Customer c1 = new Customer() { CustId = 101, Name = "Scott", City = "Hyderabad", Balance = 25000.00 };
//            Customer c2 = new Customer() { CustId = 102, Name = "Smith", City = "Chennai", Balance = 29000.00 };
//            Customer c3 = new Customer() { CustId = 103, Name = "Dave", City = "Delhi", Balance = 34000.00 };
//            Customer c4 = new Customer() { CustId = 104, Name = "David", City = "Hyderabad", Balance = 59000.00 };
//            Customers.Add(c1); Customers.Add(c2); 
//            Customers.Add(c3); Customers.Add(c4);

//            foreach (Customer obj in Customers)
//            {
//                Console.WriteLine(obj.CustId + " " + obj.Name + " " + obj.City + " " + obj.Balance);
//            }
//        }
//    }
//}
