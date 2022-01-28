using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input;
            int r, sum;
            int rev = 0;
            Console.WriteLine("Enter a number");
            input = Convert.ToInt32(Console.ReadLine());
            //Logic
            r = input;
            while (r > 0)
            {
                sum = r % 10;
                r = r / 10;
                rev = rev * 10 + sum;
            }
            //Output
            Console.WriteLine("Reverse of {0} is {1}", input, rev);
            Console.ReadLine();
        }
    }
}
