using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// ************************************************************************************
// Author : Nanam Vaishnavi
// Purpose : print numbers from 1 to 30 and skip the numbers divisible by 3.
//             HINT : use continue;
// *************************************************************************************

namespace Day14Project5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i=1; i <= 30;i++)
            {
                if (i % 3 == 0)
                    continue;

                Console.WriteLine(i);

            }
            Console.ReadLine();
            
        }
    }
}
