using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// ***********************************************
// Author : Nanam Vaishnavi
// Purpose : Trace of the matrix
//************************************************

namespace Day13Project3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[,] data = new int[,] { { 1, 5, 9 }, { 2, 6, 10 }, { 3, 7, 11 } };
            int sum = 0;
            for (int i = 0;i<3;i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == j)

                        sum = sum + data[i, j];

                }
             }
            Console.WriteLine(sum);
            Console.ReadLine();


        }
    }
}
