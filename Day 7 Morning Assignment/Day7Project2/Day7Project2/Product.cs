using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Project2
{
    internal class Product
    {
        public int product_ID;
        public string product_name;
        public int price;

        public void ReadProduct()
        {
            Console.WriteLine("Enter product_ID: ");
            product_ID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter product_Name");
            product_name = Console.ReadLine();

            Console.WriteLine("Enter price: ");
            price = Convert.ToInt32(Console.ReadLine());
        }
        public void PrintProduct()
        {
            Console.WriteLine($"product_ID = {product_ID},product_Name = {product_name}, price = {price}");

        }

        static void Main(string[] args)
        {
            Product product = new Product();
            product.ReadProduct();
            product.PrintProduct();

            Console.ReadLine();
        }


    }
}
