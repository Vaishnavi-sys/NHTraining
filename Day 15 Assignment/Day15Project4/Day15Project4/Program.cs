using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
// ******************************************
// Author : Nanam Vaishnavi
// Purpose : C# program to read data from file.
//*******************************************

namespace Day15Project4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            StreamReader sr = new StreamReader("F:\\NH\\DotNetProjects\\Day 15 Assignment\\File.txt");
            {
                while(true)
                {
                    string line = sr.ReadLine();
                    if(line == null)
                    {
                        break;
                    }
                    Console.WriteLine(line);
                }
            }



            Console.WriteLine("File reading done");
            Console.ReadLine();

        }
    }
}
