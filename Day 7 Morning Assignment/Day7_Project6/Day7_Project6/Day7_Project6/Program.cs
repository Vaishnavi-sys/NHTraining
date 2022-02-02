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
                    new Customer() { id = 1, name ="abhi", points =26},
                    new Customer() { id = 2, name ="Ram",points=29},
                    new Customer() { id = 3, name ="Jaya",points=67},
                    new Customer() { id = 4, name ="Aravind",points=10},
                    new Customer() { id = 5, name ="Shiva",points=40}
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

 