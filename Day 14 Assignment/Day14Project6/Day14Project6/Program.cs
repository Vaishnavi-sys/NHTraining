using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// ********************************************************
// Author : Nanam Vaishnavi
// Purpose : 6. Find the first number after 1000 which is divisible by 97.
//                HINT : use for loop and break
// **********************************************************
namespace Day14Project6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i=1000;i<=1097; i++)
            {
                if (i % 97 == 0)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
            Console.ReadLine(); 
        }
    }
}
