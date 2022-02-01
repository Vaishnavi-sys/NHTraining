using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seller
{
    internal class Seller_1
    {
        public int id;
        public string name;
        public string email;

        public void ReadSeller()
        {
            Console.WriteLine("Enter ID: ");
            id = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter Name: ");
            name = Console.ReadLine();

            Console.WriteLine("Enter Email: ");
            email = Console.ReadLine();
        }
        public void PrintSeller()
        {
            Console.WriteLine($"ID ={id} , Name ={name}, email{email} ");
        }
        static void Main(string[] args)
        {
            Seller_1 sell = new Seller_1();
            sell.ReadSeller();
            sell.PrintSeller();

            Console.ReadLine();

        }
    }
}
