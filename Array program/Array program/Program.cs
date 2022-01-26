using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, n, sum = 0;
            double avg;
            Console.Write("Input the 5 numbers : \n");
            for (i = 1; i <= 5; i++)
            {
                Console.Write("Number-{0} :", i);

                n = Convert.ToInt32(Console.ReadLine());
                sum += n;
            }
            avg = sum / 5;
            Console.WriteLine("The sum  is : {0}\nThe Average is : {1}\n", sum, avg);
            Console.ReadLine();
        }
    }
}
   