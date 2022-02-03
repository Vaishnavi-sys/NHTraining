using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//*********************************
//Author : Nanam Vaishnavi
//Purpose: Operations
//********************************
 

namespace Day9Project1
{
    class Operations
    {
        private int input;

        public void ReadInput()
        {
            Console.WriteLine("Enter number: ");
            input=Convert.ToInt32(Console.ReadLine());  
        }

        public int Factorial()
        {
            int fact = 1;
            for(int i=1;i<=input;i++)
            {
                fact = fact * i;
            }
            return fact;
        }

        
        public void Factors()
        {
            for(int i = 1;i<=input;i++)
            {
                if(input%i==0)
                    Console.WriteLine(i);
            }
        }


        public bool IsPrime()
        {
            int count = 0;
            for(int i=1;i<input;i++)
            {
                if (input % 1 == 0)
                    count++;
            }
            if (count == 2)
                return true;
            else
                return false;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Operations ob = new Operations();
            ob.ReadInput();
            Console.WriteLine(ob.Factorial());
            ob.Factors();
            if (ob.IsPrime())
                Console.WriteLine("Input is PRIME Number");
            else
                Console.WriteLine("Not a Prime Number");
          
            Console.ReadLine();
        }
    }
}
