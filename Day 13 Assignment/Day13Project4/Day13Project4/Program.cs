using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// **************************************************
// Author : Nanam Vaishnavi
// Purpose : Read values from and print the matrix
// **************************************************

namespace Day13Project4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] data = new int[2,2];

            // Read values from user

            for(int i =0;i<2;i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine($"Enter array values at ({i},{j})"); 
                    data[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("\n");
            // Print Values
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(data[i,j]+ " ");
                }
                Console.WriteLine("\n");
            }
            Console.ReadLine();
            
            
        }
        
    }
}
