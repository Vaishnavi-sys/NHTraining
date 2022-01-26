using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foreach_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[5];
            int Sum = 0;


            //Read data from user
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine("Enter number:");
                data[i] = Convert.ToInt32(Console.ReadLine());

            }

            //Logic and output
            foreach (int d in data)
            {
                Sum = Sum + d;
            }
            Console.WriteLine("Sum =" + Sum);

            Console.ReadLine();

        }
    }
}
    

