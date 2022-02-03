using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// *************************************************
// Author : Nanam Vaishnavi
// Purpose : Arithmetic Operations
//***************************************************

namespace Day9Project2
{
    class ArithmeticOperations
    {
        private int a;
        private int b;
        
        public void ReadInput()
        {
            Console.WriteLine("Enter First Number: ");
            a= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number: ");
            b= Convert.ToInt32(Console.ReadLine());

        }
        public int AddNumbers()
        {
            return a + b;

        }

        public int Difference()
        {
            return a - b;
        }

        public int Product()
        {
            return a * b;
        }

        public int Division()
        {
            return a % b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ArithmeticOperations ar = new ArithmeticOperations();
            ar.ReadInput();
            Console.WriteLine(ar.AddNumbers());
            Console.WriteLine(ar.Difference());
            Console.WriteLine(ar.Product());
            Console.WriteLine(ar.Division());
            Console.ReadLine();
            
        }
    }
}
