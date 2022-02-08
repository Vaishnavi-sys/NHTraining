using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Exception_Handlings
{
     
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                int a, b, c;
                Console.WriteLine("Enter a: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter b: ");
                b = Convert.ToInt32(Console.ReadLine());
               
                c = a / b;
                Console.WriteLine(c);
                Console.ReadLine();
            }
            
            catch (FormatException)
            {
                Console.WriteLine("Enter Numbers. Please check again");
                Console.ReadLine();
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("can't divide by zero");
                Console.ReadLine();
            }
            finally
            {
                Console.WriteLine("Error Occured");
                Console.ReadLine();

            }
        }
    }
}
