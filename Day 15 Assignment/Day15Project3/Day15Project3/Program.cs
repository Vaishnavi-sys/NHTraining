using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// ***********************************
// Author : Nanam Vaishnavi
// Purpose : WACP to write data into file (and append the data) using Stream writer class.
// ************************************

namespace Day15Project3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*StreamWriter sw = new StreamWriter("F:\\NH\\DotNetProjects\\Day 15 Assignment\\Vaishu.txt");
             {
                 sw.WriteLine("Welcome");
                 sw.WriteLine("to");
                 sw.WriteLine("NBH");
                 sw.WriteLine("Technologies");
                 sw.Close();

             }*/


            StreamWriter sw = new StreamWriter("F:\\NH\\DotNetProjects\\Day 15 Assignment\\Vaishu.txt", true);
            {
                sw.WriteLine("Welcome");
                sw.WriteLine("to");
                sw.WriteLine("C Sharp");
                sw.WriteLine("classes");

                sw.Close();

                Console.WriteLine("File Ready");

                Console.ReadLine();
            }
        }
    }
}


