using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// *********************************************
// Author : Nanam Vaishnavi
// Purpose : 2D Array using nested for loop
// *********************************************

namespace Day13project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int[,] data = new int[2, 2];
            {
                data[0, 0] = 12;
                data[0, 1] = 26;
                data[1, 0] = 32;
                data[1, 1] = 45;

            };
           
            for (int i=0;i<2;i++)
            {
                for (int j=0;j<2;j++)
                {
                    Console.Write(data[i, j] + " ");
                    
                }
                Console.WriteLine("\n");


            }
            
            Console.ReadLine();




            


            }
            
        }
}

