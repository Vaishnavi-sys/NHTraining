using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// ********************************************
// Author : Nanam Vaishnavi
// purpose : program to print Hello World in Object Oriented way.
// *********************************************

namespace Day16Project1
{
    class Message
    {
        public string PrintHi()
        {
            return "Hello World";
        }
        

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Message m = new Message();
            Console.WriteLine(m.PrintHi());

            Console.ReadLine();

        }
    }
}
