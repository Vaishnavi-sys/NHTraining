using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input;
            int d, sum;
            int res = 0;
            Console.WriteLine("Enter a number");
            input = Convert.ToInt32(Console.ReadLine());
            //Logic
            d = input;
            while (d > 0)
            {
                sum = d % 10;
                d = d / 10;
                res = res + sum;
            }
            //Output
            Console.WriteLine("Sum of the digits of {0} is {1}", input, res);
            Console.ReadLine();
        }
    }
}
