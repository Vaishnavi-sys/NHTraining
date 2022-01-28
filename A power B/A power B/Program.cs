using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_power_B
{
    internal class Program
    {
        public static int Power(int a, int b)
        {
            int p = 1;
            for(int i =1;i<b;i++)
                p *= a;
            return p;
        }

        static void Main(string[] args)
        {
            int a1 = 5; int b1 = 4 , a2 = 2, b2 = 6 , a3 = 3, b3 = 5;

            Console.WriteLine("{0} power {1} = {2}", a1, b1, Power(a1, b1));
            Console.WriteLine("{0} power {1} = {2}", a2, b2, Power(a2, b2));
            Console.WriteLine("{0} power {1} = {2}", a2, b2, Power(a3, b3));



            Console.ReadLine();
        }
    }
}
