using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
// ************************************
// Author : Nanam Vaishnavi
// Purpose : copy files from one folder to other folder using Task Schedule.
// *************************************

namespace ConsoleApp123
{
    internal class Program
    {
        static void Main(string[] args)
        {
            File.Copy("G:\\Vaisha\\Text26.txt", "G:\\FileProgram1\\Text26.txt");
            Console.WriteLine("File Copy Done");
            Console.ReadLine();
        }
    }
}
