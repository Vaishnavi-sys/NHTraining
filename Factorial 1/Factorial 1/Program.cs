using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, num, fact = 1;

            Console.WriteLine("Enter num :");
            num = Convert.ToInt32(Console.ReadLine());  
            
            for(i =1;i<=num;i++)
            {
                fact = fact*i;
            }
            Console.WriteLine("Factorial of " +num+ " is: " + fact);
            Console.ReadLine();

        }
    }
}
