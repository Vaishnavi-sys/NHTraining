using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Primenumbers_in_a_range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable declaration and reading data from user
            int i1, i2;
            Console.WriteLine("Enter first number");
            i1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            i2 = Convert.ToInt32(Console.ReadLine());
            for (int i = i1; i <= i2; i++)
            {
                if (isPrimenumber(i))
                    Console.WriteLine("{0}", i);
            }
            Console.ReadLine();

        }
        //Logic and returning Output
        public static Boolean isPrimenumber(int input)
        {
            int i;
            for (i = 2; i < input; i++)
            {
                if (input % i == 0)
                    break;
            }
            if (i == input)
                return true;
            else
                return false;
        }

    }
}
