using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// ******************************************************************************
// Author : Nanam Vaishnavi
// Purpose : initializing values in declaration line  and printing values
// /*****************************************************************************
namespace Day13Project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] data = new int[3, 2] { { 5, 6 },{ 12, 24 }, { 13, 25 } };
            for(int i =0;i<3;i++)
            {
                for(int j=0;j<2;j++)
                {
                    Console.Write(data[i, j] + " ");
                }
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}
