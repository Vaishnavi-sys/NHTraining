using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
// **********************************************
// Author : Nanam Vaishnavi
// Purpose : files using create()Method 
// **********************************************

namespace Day15Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            File.Create("F:\\NH\\DotNetProjects\\Day 15 Assignment\\Vaishu.txt");
            Console.WriteLine("File Created");

            Console.ReadLine(); 
        }
    }
}
