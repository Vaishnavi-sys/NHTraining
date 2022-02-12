using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace FileMethods
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
