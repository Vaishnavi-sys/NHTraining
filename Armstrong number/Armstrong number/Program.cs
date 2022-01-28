using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armstrong_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input1, input2, i;
            Console.WriteLine("Enter first number");
            input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            input2 = Convert.ToInt32(Console.ReadLine());
            //Printing Output
            Console.WriteLine("Armstrong numbers between the given range:");
            for (i = input1; i <= input2; i++)
            {
                if (isArmstrongnumber(i))
                    Console.WriteLine(i);
            }
            Console.ReadLine();
        }
        //Logic
        public static Boolean isArmstrongnumber(int input)
        {
            int m, rem;
            int result = 0;
            m = input;
            while (m > 0)
            {
                rem = m % 10;
                m = m / 10;
                result = result + rem * rem * rem;
            }
            if (result == input)
                return true;
            else
                return false;
        }


    }
}

