using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// ******************************************
// Author : Nanam Vaishnavi
// Purpose : Product of Matrices.
//*******************************************

namespace Day13Project6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] p1 = new int[2, 2];


            //Read values for p1 from user

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine($"Enter First Matrix ({i},{j}): ");
                    
                    p1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            int[,] p2 = new int[2, 2];

            //Read values for p2 from user

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine($" Enter Second Matrix({i},{j}):  ");
                    
                    p2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }




            // Product of  two matrixes
            Console.WriteLine("Product of Two Matrices");

            int[,] p3 = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    p3[i, j] = p1[i, j] * p2[i, j];

                }

            }

            // printing matrix
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(p3[i, j] + " ");
                }
                Console.Write("\n \n");

            }
            Console.ReadLine();
        }
    }
}
