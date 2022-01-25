using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_Project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fn, sn, sum = 0;
            int f = 1;

            fn = 8;

            Console.WriteLine("Enter First Number:");
            fn = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number:");
            sn = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= sn; i++)
                f = f * fn;
            Console.WriteLine("Power =" + f);
            Console.ReadLine(); 
        }
    }
}
