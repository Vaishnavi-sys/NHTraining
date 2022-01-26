using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplication_0__fromat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, v;
            Console.WriteLine("Enter number: ");
            v = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= 10; i++) 
            {
                Console.WriteLine("{0}*{1}={2}", v, i, v * i);
            }
            Console.ReadLine();
        }
    }
}
