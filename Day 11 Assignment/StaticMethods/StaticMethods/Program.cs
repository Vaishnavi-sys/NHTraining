using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// ********************************************************
// Author : Nanam Vaishnavi
// Purpose : Mathematics class and add static methods.
//**********************************************************

namespace StaticMethods
{
    class Mathematics
    {
        public static int Add(int a, int b)
        {
            return a + b;   
        }
        public static int Sub(int a, int b)
        {
            return a - b;
        }
        public static int Mul(int a, int b)
        {
            return (a * b);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Mathematics.Add(6,5));
            Console.WriteLine(Mathematics.Sub(9,4));
            Console.WriteLine(Mathematics.Mul(6, 8));

            Console.ReadLine();
        }
    }
}
