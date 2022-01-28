using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_or_not
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, v, count = 0;

            Console.WriteLine("Enter any number: ");
            v = Convert.ToInt32(Console.ReadLine());    

            for(i=1;i<=v;i++)
            {
                if (v % i == 0)
                    count++;

            }
            if (count == 2)
                Console.WriteLine("{0} is a PRIME number", v);
            else
                Console.WriteLine("{0} is NOT a PRIME Number", v);

            Console.ReadLine();
        }
    }
}
