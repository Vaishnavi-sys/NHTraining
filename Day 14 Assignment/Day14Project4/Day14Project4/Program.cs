using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Project4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int v , i;
            Console.WriteLine("Enter a number: ");
            v = Convert.ToInt32(Console.ReadLine());    
            for(i=2;i<v;i++)
            {
                if (v % i == 0)
                    break;
            }

            if (i == v)
                Console.WriteLine("PRIME");
            else
                Console.WriteLine("NOT PRIME");

            Console.ReadLine();
        }
    }
}
