using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// *******************************
// Author : Nanam Vaishnavi
// Purpose :To illustrate nullable types
// *******************************

namespace Day20Project2
{
    internal class Nullable
    {
        static void Main(string[] args)
        {
            int ? salary = 60000;
            Console.WriteLine(salary);

            byte ? age = null;
            if (age.HasValue)
                Console.WriteLine(age * age);
            else
                Console.WriteLine("No Value");
            Console.ReadLine();

           
            
        }
    }
}
