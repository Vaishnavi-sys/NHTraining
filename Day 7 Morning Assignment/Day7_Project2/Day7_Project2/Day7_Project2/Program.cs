using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_Project2
{
    internal class Customer
    {
        public int cust_id;
        public string cust_Name;
        public string cust_Email;
        public void ReadCustomer()
        {
            Console.WriteLine("Enter Cust_ID: ");
            cust_id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Cust_Name");
            cust_Name = Console.ReadLine();

            Console.WriteLine("Enter Cust_Email: ");
            cust_Email = Console.ReadLine();
        }
        public void PrintCustomer()
        {
            Console.WriteLine($"cust_ID= {cust_id} ,cust_Name= {cust_Name} , cust_Email= {cust_Email}");

        }

        static void Main(string[] args)
        {
            Customer cust = new Customer();
            cust.ReadCustomer();
            cust.PrintCustomer();

            Console.ReadLine();
        }


    }
}
            

