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
    internal class Operations
    {
        public delegate void add(int a, int b);
        public delegate void mul(int a, int b);

        /// <summary>
        /// Adding 2 numbers
        /// </summary>
        
        public void Sum(int a, int b)
        {
            Console.WriteLine("(80+20) = {0}", a+b);
        }
         /// <summary>
         /// Multiplication
         /// </summary>
        
        public void Multiply(int a, int b)
        {
            Console.WriteLine("(8*6) = {0}", a*b);
        }
        public static void Main(string[] args)
        {
            Operations op = new Operations();

            add obj1 = new add(op.Sum);
            mul obj2 = new mul(op.Multiply);

            obj1(80, 20);
            obj2(8, 6);

            Console.ReadLine();
        }       
    }
}
