using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//**************************************************
//Author : Nanam Vaishnavi
//Purpose : class Product using 4 loops.
//**************************************************

namespace Day8Project3
{
    class Product
    {
        public int id;
        public string name;
        public int price;
        public string brand;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> product = new List<Product>()
            {
                new Product() {id=1, name = "TouchPen", price = 400, brand="ELV Direct" },
                new Product(){id=2, name = "Bluetooth", price = 500, brand= "Oneplus Bullets" },
                new Product(){id=3, name = "Mouse", price=1000, brand = "Razer" },
                new Product(){id=4, name = "Headsets", price=600, brand="Apple" },
                new Product(){id=5, name = "Keyboard", price=900, brand="H.P" },
            };
            

            Console.WriteLine("*****************************************************************************");

            // forloop
            for (int i = 0; i < product.Count; i++)
            {
                if (product[i].price > 500)
                    Console.WriteLine($"id={product[i].id}, name={product[i].name}, price={product[i].price}, Brand={product[i].brand}");
            }

            Console.WriteLine("*****************************************************************************");

            //foreach loop
            foreach(var p in product)
            {
                if (p.price > 500)
                    Console.WriteLine($"id={p.id},name={p.name}, Price={p.price}, Brand={p.brand}");

            }

            Console.WriteLine("*****************************************************************************");

            //Lambda Expression
            product.ToList().Where(p=>p.price>500).ToList().ForEach(p=>Console.WriteLine($"id={p.id},name={p.name}, Price={p.price}, Brand={p.brand}"));

            Console.WriteLine("*****************************************************************************");

            // LinQ 
            var result = from p in product
                         where p.price >500
                         select p;
            result.ToList().ForEach(p => Console.WriteLine($"id={p.id},name={p.name}, Price={p.price}, Brand={p.brand}"));

            Console.WriteLine("*****************************************************************************");

            Console.ReadLine();
        }

    }
}
