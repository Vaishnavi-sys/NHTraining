using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplication_whileloop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m, k = 1;
            Console.WriteLine("Enter any number:");
            m = Convert.ToInt32(Console.ReadLine());

            while (k<= 10)
            {
                Console.WriteLine(m + "*" + k + "=" + m * k);
                k++;

            }
            
            Console.ReadLine();
        }
    }
}
