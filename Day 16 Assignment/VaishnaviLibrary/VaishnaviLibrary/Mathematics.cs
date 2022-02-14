using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// *************************************
// Author : Nanam Vaishnavi
// Purpose: Using Library and creating 3 classes in it.
// ****************************************

namespace VaishnaviLibrary
{
    public class Mathematics
    {
        int input;
        /// <summary>
        /// Read Data
        /// </summary>
        public void ReadData()
        {
            Console.WriteLine("Enter Number: ");
            input = Convert.ToInt32(Console.ReadLine());

        }
        /// <summary>
        /// GetFactorial
        /// </summary>
        /// <returns></returns>
        public int GetFactorial()
        {
            int fact = 1;
            for (int i = 1; i <= input; i++)
                fact = fact * i;
            return fact;
        }


    }

    

    
    }



