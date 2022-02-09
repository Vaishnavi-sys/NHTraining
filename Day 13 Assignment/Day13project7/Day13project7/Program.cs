using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// **********************************************
// Author : Nanam Vaishnavi
// Purpose : Declare Jagged Array  and print values
// ************************************************

namespace Day13project7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[][] names = new char[3][];
            names[0] = new char[] { 'A', 'b', 'h', 'i' };
            names[1] = new char[] { 'R', 'a', 't', 'h', 'i', 'k', 'a' };
            names[2] = new char[] { 'K', 'a', 'r', 't', 'h', 'i', 'k' };

            for(int i=0;i<3;i++)
            {
                for(int j =0;j<names[i].Length;j++)
                {
                    Console.Write(names[i][j]);
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
