using System;
using System.Collections.Generic;

namespace Customer
{
    internal class Customer_1
    {

        public int cust_ID;
        public string cust_Name;
        public string cust_Email;

        

        public void ReadCustomer()
        {
            Console.WriteLine("Enter Cust_ID: ");
            cust_ID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Cust_Name");
            cust_Name = Console.ReadLine();

            Console.WriteLine("Enter Cust_Email: ");
            cust_Email = Console.ReadLine();
        }
        public void PrintCustomer()
        {
            Console.WriteLine($"cust_ID= {cust_ID} ,cust_Name= {cust_Name} , cust_Email= {cust_Email}");

        }

        static void Main(string[] args)
        {
            Customer_1 cust = new Customer_1();
            cust.ReadCustomer();
            cust.PrintCustomer();

            Console.ReadLine();
        }
    }
}
