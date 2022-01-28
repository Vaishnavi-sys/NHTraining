using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_series
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input;
            int v = 0, p = 1;
            Console.WriteLine("Enter a number");
            input = Convert.ToInt32(Console.ReadLine());
            //Logic and printing output
            Console.WriteLine("Fibbonaci series:");
            for (int i = 0; i < input; i++)
            {
                Console.WriteLine(v);
                int c = v + p;
                v = p;
                p = c;
            }
            Console.ReadLine();

        }
    }
}
