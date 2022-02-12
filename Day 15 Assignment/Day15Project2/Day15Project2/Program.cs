using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
// ********************************************
// Author : Nanam Vaishnavi
// Purpose : copy files from one folder to other folder. using Task Scheduler.


namespace Day15Project2
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            File.Copy("G:\\FileProgram\\Hello.txt", "G:\\FileProgram1\\Hello.txt");
            Console.WriteLine("File copy done");

            Console.ReadLine();
        }
    }
}
