using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        class Human
        {
            public string eyes;
            public string tongue;
            
            public void EYE()
            {
                Console.WriteLine("TO LOOK");
            }
            public void Tongue()
            {
                Console.WriteLine("To Taste");
            }
        }
        class Food : Human
        {
            public void ReadMenu()
            {
                Console.WriteLine("food");
            }
                
        }
        static void Main(string[] args)
        {
            Food f = new Food();
            f.EYE();
            Console.ReadLine();
        }
    }
}
