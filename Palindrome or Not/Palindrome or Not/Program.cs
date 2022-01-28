using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_or_Not
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable declaration and read data from user
            int k;
            int p, palin;
            int rev = 0;
            Console.WriteLine("Enter a number");
            k = Convert.ToInt32(Console.ReadLine());
            //Logic and Output
            p = k;
            while (p > 0)
            {
                palin = p % 10;
                p = p / 10;
                rev = rev * 10 + palin;
            }
            if (k == rev)
                Console.WriteLine("{0} is a Palindrome", k);
            else
                Console.WriteLine("{0} is not a Palindrome", k);
            Console.ReadLine();
        }
    }
}
