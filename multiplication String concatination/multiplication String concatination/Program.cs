using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplication_String_concatination
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, i;
            Console.WriteLine("Enter any number: ");
            n = Convert.ToInt32(Console.ReadLine());

            for(i=1;i<=10;i++)
            {
                Console.WriteLine(n+"*"+i+"="+n*i);
            }
            Console.ReadLine();
        }
    }
}
