using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach_loop1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int[] data = new int[4];
            for (int i=0;i<data.Length;i++)
            {
                Console.WriteLine("Enter Number");
                data[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("The numbers you entered are:");
           

            foreach (int d in data)
                Console.WriteLine(d);

            Console.ReadLine();
        }
    }
}

        


            
