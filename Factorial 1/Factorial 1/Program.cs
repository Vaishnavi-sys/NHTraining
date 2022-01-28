using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorialusingrecurssion
{
    internal class Program
    {
        public static void Output(int n)
        {
            Console.WriteLine("Factorial of {0} ={1}", n, factorial(n));
        }
        //Logic
        public static int factorial(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
                fact = fact * i;
            return fact;
        }

        static void Main(string[] args)
        {
            //Intialisation and read data from user
            int n, n1, n2;

            Console.WriteLine("Enter first number");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number");
            n2 = Convert.ToInt32(Console.ReadLine());
            Output(n);
            Output(n1);
            Output(n2);
            Console.ReadLine();
        }
    }



}








