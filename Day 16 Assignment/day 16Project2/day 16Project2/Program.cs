using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_16Project2
{
    class Mathematics
    {
        int input, fact = 1;
        public void ReadData()
        {
            Console.WriteLine("Enter Number: ");
            input = Convert.ToInt32(Console.ReadLine());
            
        }
        public int GetFactorial()
        {

            for (int i = 1; i <= input; i++)
                fact = fact * i;
            return fact;
        }
       
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Mathematics m = new Mathematics();
            m.ReadData();
            Console.WriteLine(m.GetFactorial());


            Console.ReadLine();
        }
    }
}
