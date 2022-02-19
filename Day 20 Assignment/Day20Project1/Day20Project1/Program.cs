using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// ***********************************
// Author : Nanam Vaishnavi
// Purpose : C# code to illustrate the usage of delegates.
// ***********************************

namespace Day20Project1
{
    public delegate void Operations(int a, int b);
    internal class Program
    {
        public static void Add(int a, int b)
        {
            Console.WriteLine( a + b);
        }

        public static void Mul(int a, int b)
        {
            Console.WriteLine( a * b);
        }

        public static void Div(int a, int b)
        {
            Console.WriteLine(a/b);
        }
        static void Main(string[] args)
        {
            Operations op = new Operations(Add);

            op += Div;
            op += Mul;

            //15,16
            op(15, 16);
            Console.WriteLine("==========================");

            // 12,13
            op(12, 13);
            Console.WriteLine("===========================");

            // 14,18
            op(14, 18);
            Console.WriteLine("===========================");

            Console.ReadLine();
        }       
    }
}
