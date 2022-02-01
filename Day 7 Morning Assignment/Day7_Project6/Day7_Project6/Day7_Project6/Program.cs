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
        public int points;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer[] customer = new Customer[]
                {
                    new Customer() { id = 1, name ="john", points =95},
                    new Customer() { id = 2, name ="prasad",points=25},
                    new Customer() { id = 3, name ="sai",points=10},
                    new Customer() { id = 4, name ="uday",points=64},
                    new Customer() { id = 5, name ="jp",points=40}
                };

            Console.WriteLine("===========================================================");

            //using for loop
            for (int i = 0; i < customer.Length; i++)
            {
                if (customer[i].points >= 30)
                    Console.WriteLine($"id={customer[i].id},name={customer[i].name},Points={customer[i].points}");
            }

            Console.WriteLine("===========================================================");

            //using foreach
            foreach (var e in customer)
            {
                if (e.points >= 30)
                    Console.WriteLine($"id={e.id},name={e.name},Points{e.points}");
            }

            Console.WriteLine("===========================================================");

            //using lamda expression

            customer.ToList().Where(e => e.points >= 30).ToList().ForEach(e => Console.WriteLine($"id={e.id},name={e.name},Points{e.points}"));

            Console.WriteLine("===========================================================");

            Console.ReadLine();
        }
    }
}

 