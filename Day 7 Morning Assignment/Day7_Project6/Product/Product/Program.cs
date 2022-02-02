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
                    new Product() { id = 1, name ="Laptop", price =45000},
                    new Product() { id = 2, name ="Phone",price=15000},
                    new Product() { id = 3, name ="Desktop",price=10000},
                    new Product() { id = 4, name ="Tablet",price=30000},
                    new Product() { id = 5, name ="Camera",price=25000}
                };
            //using for loop
            for (int i = 0; i < product.Length; i++)
            {
                if (product[i].price >= 20000)
                    Console.WriteLine($"id={product[i].id},name={product[i].name},Price={product[i].price}");
            }

            Console.WriteLine("========================================================");
            //using foreach
            foreach (var e in product)
            {
                if (e.price >= 20000)
                    Console.WriteLine($"id={e.id},name={e.name},Price{e.price}");
            }

            Console.WriteLine("========================================================");

            
            //using lamda expression

            product.ToList().Where(e => e.price >= 20000).ToList().ForEach(e => Console.WriteLine($"id={e.id},name={e.name},Price{e.price}"));
            Console.ReadLine();
        }
    }
}
