using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// **************************************
// Author : Nanam Vaishnavi
// Purpose : Multiplication Table in object oriented way.
// **************************************

namespace Day16Project4
{

    class Multable
    {
        int n;
        /// <summary>
        /// Read input from user
        /// </summary>
        public void ReadData()
        {
            Console.WriteLine("Enter n: ");
            n = Convert.ToInt32(Console.ReadLine());    
        }
        /// <summary>
        /// GetFactorial
        /// </summary>
        public void GetMultiplication()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0}*{1}={2}", n, i, n * i);
                
            }
           
           
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Multable mult = new Multable();
                mult.ReadData();
                mult.GetMultiplication();

                Console.ReadLine();

            

            
        }
    }
}
