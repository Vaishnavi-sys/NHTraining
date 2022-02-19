using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// ********************************
// Author : Nanam Vaishnavi 
// Purpose :  Program using OUT parameter
// ********************************

namespace Day20Project3
{
    internal class Program
    {
        public static void Sum (out int V)
        {
            V = 60;
            V = V + 60;
        }
        static void Main(string[] args)
        {
            int V;
            Sum (out V);
            Console.WriteLine ("Sum of Value is : {0}",V);

            Console.ReadLine();
        }
    }
}
