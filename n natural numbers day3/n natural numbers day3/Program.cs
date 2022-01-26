using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n_natural_numbers_day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int j, n, sum =0;

            Console.WriteLine("Enter n number");
            
            n = Convert.ToInt32(Console.ReadLine());

            for (j = 1; j <=n; j++)
            
                sum+=j;
            

            Console.WriteLine("\nSum of N Numbers : " + sum);
            Console.ReadLine();
                
            

        }
    }
}
