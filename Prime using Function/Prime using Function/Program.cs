using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_using_Function
{
    internal class Program
    {
        public static bool Prime(int num)
        {
            for(int i=2;i<num;i++)
                if(num%i==0)
                    return true;
            return false;
        }
        public static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter any Number :");
            int p = Convert.ToInt32(Console.ReadLine());
                if (Prime(p))
                    Console.WriteLine("{0} is NOT PRIME.", p);
                else
                    Console.WriteLine("{0} is PRIME.", p);
            Console.ReadLine();

        }
    }
            
}
    
   
           

        

