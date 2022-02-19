
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// ****************************
// Author : Nanam Vaishnavi
// Purpose : C# code using REF parameter
// ****************************

namespace Day20Project4
{
    internal class Program
    {
        
        private static void SetValue(ref string str1)
        {
           // Checking parameter value
            if (str1 == "NBH")
            {
                Console.WriteLine("Welcome to NBH");
            }
            
            // Assigning new value 
            str1 = "Hello NBH!!!";

        }
        static void Main(string[] args)
        {
            string str = "NBH";
            SetValue(ref str);
            Console.WriteLine(str); 

            Console.ReadLine();
        }


        
    }
}
