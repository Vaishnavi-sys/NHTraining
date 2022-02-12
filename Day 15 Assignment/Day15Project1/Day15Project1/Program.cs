using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
// **********************************************
// Author : Nanam Vaishnavi
// Purpose : using File Methods
// **********************************************
// Author : Nanam Vaishnavi
// Purpose : 10 methods present in  File Class
// ***********************************************
namespace Day15Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* File.Create("F:\\NH\\DotNetProjects\\Day 15 Assignment\\Vaishu.txt");
             Console.WriteLine("File Created");

             Console.ReadLine(); */

            /*File.WriteAllText("F:\\NH\\DotNetProjects\\Day 15 Assignment\\Vaishu.txt", "Welcome to NBH. ");
            Console.WriteLine("File Read");
            Console.ReadLine();*/


            /*File.AppendAllText("F:\\NH\\DotNetProjects\\Day 15 Assignment\\Vaishu.txt","Started C# Classes");
            Console.WriteLine("File Append");
            Console.ReadLine();*/

            /*Console.WriteLine(File.GetCreationTime("F:\\NH\\DotNetProjects\\Day 15 Assignment\\Vaishu.txt"));
             Console.ReadLine();*/

            /*File.Encrypt("F:\\NH\\DotNetProjects\\Day 15 Assignment\\Vaishu.txt");
            Console.WriteLine("File Encrypted");
            Console.ReadLine();*/

            /*File.Decrypt("F:\\NH\\DotNetProjects\\Day 15 Assignment\\Vaishu.txt");
            Console.WriteLine("File Decrypted");
            Console.ReadLine();*/

            /*File.Copy("F:\\NH\\DotNetProjects\\Day 15 Assignment\\Vaishu.txt", "G:\\New folder\\Vaishu.txt");
            Console.WriteLine("File Copied");
            Console.ReadLine();*/

            /*File.Delete("G:\\New folder\\Vaishu.txt");
            Console.WriteLine("File Deleted");
            Console.ReadLine();*/

            /*string CurrentFile = "G:\\New folder\\Vaishu.txt";
            Console.WriteLine(File.Exists(CurrentFile) ? "File Exists.": "File doesn't exists");
            Console.ReadLine();*/

            File.Move("F:\\NH\\DotNetProjects\\Day 15 Assignment\\Vaishu.txt", "G:\\New folder\\Vaishu.txt");
            Console.WriteLine("File Moved to other folder");
            Console.ReadLine();

        }

    }
}
