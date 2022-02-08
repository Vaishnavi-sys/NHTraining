using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                string[] arr = { "Hello","World"};
                object[] arr2 = arr;
                arr2[2] = 10;
            }
            catch (ArrayTypeMismatchException e)
            {
                Console.WriteLine("Not defined");
            }

        }
    }


}
    

