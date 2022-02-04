using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// **************************************************************
// Author : Nanam Vaishnavi
// Purpose : Single Inheritance
// **************************************************************

namespace Inheritance
{
    class Algebra
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Sub(int a, int b)
        {
            return a - b;
        }
    }

    class TotalMaths : Algebra
    {
        public int Mul(int a, int b)
        {
            return (a * b);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            TotalMaths tm = new TotalMaths();
            Console.WriteLine(tm.Add(6, 6));
            Console.WriteLine(tm.Sub(14, 9));
            Console.WriteLine(tm.Mul(4, 7));

            Console.ReadLine();
        }
    }
}
