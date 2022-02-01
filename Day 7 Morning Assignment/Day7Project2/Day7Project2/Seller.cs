using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Project2
{
    internal class Seller
    {
        public int id;
        public string name;
        public short phone_number;

        public void ReadSeller()
        {
            Console.WriteLine("Enter ID: ");
            id = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter Name: ");
            name = Console.ReadLine();

            Console.WriteLine("Enter Phone_Number");
            phone_number = Convert.ToInt16(Console.ReadLine());
        }
        public void PrintSeller()
        {
            Console.WriteLine($"ID ={id} , Name ={name}, Phone_Number={phone_number} ");
        }
        static void Main(string[] args)
        {
            Seller seller = new Seller();
            seller.ReadSeller();
            seller.PrintSeller();

            Console.ReadLine();

        }

    }
}
