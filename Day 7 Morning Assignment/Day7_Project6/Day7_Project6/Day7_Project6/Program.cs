using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_Project6
{
    class Customer
    {
        public int id;
        public string name;
        public string email;
    }
      
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer[] customer = new Customer[6];
            {
                customer[0] = new Customer() { id = 1, name = "Vaishu", email = "vaish@gmail.com" };
                customer[1] = new Customer() { id = 2, name = "Sindhu", email = "abcd@gmail.com" };
                customer[2] = new Customer(){ id = 3, name = "Pavan", email = "pavan@gmail.com" };
                customer[3] = new Customer() { id = 4, name = "Mouni", email = "Mouni25@gmail.com" };
                customer[4] = new Customer() { id = 5, name = "swathi", email = "swathi_6@gmail.com" };
            }
            Console.WriteLine("=======================================================================================");
            // for loop
            for(int i=0;i<customer.Length;i++)
            {
                Console.WriteLine($"id={customer[i].id}, name={customer[i].name}, email={customer[i].email}");

            }

            Console.WriteLine("=======================================================================================");
            // foreach loop
            foreach (var c in customer)
            {
                Console.WriteLine($"id={c.id}, name={c.name}, email={c.email}");
            }

            Console.WriteLine("=======================================================================================");
            // Lambda Expression
            customer.ToList().ToList().ForEach(c => Console.WriteLine($"id={c.id},name={c.name},salary{c.email}"));
            Console.ReadLine();
        }
    }

}
 