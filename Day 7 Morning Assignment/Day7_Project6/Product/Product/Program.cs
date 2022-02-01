using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class Product
    {
        public int id;
        public string name;
        public int price;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Product[] product = new Product[]
                {
                    new Product() { id = 1, name ="Kavya", price =955},
                    new Product() { id = 2, name ="Aravind",price=255},
                    new Product() { id = 3, name ="Sushma",price=10},
                    new Product() { id = 4, name ="vaishnavi",price=64},
                    new Product() { id = 5, name ="Jaya",price=40}
                };
            //using for loop
            for (int i = 0; i < product.Length; i++)
            {
                if (product[i].price >= 100)
                    Console.WriteLine($"id={product[i].id},name={product[i].name},Price={product[i].price}");
            }

            Console.WriteLine("========================================================");
            //using foreach
            foreach (var e in product)
            {
                if (e.price >= 100)
                    Console.WriteLine($"id={e.id},name={e.name},Price{e.price}");
            }

            Console.WriteLine("========================================================");

            //using foreach
            //using lamda expression

            product.ToList().Where(e => e.price >= 100).ToList().ForEach(e => Console.WriteLine($"id={e.id},name={e.name},Price{e.price}"));
            Console.ReadLine();
        }
    }
}
