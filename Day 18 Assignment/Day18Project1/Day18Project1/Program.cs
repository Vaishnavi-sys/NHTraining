using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day18Project1
{

    class Human
    {
        public string eyes;
        public string nose;
        public string tongue;

        public void ToSee()
        {
            Console.WriteLine( "Read the Menu");
            eyes= Console.ReadLine();

        }
        public void ToSmell()
        {
            Console.WriteLine("Food Smell?");
            nose= Console.ReadLine();
        }
        public void ToTaste()
        {
            Console.WriteLine("Food Taste?");
            tongue= Console.ReadLine();
        }
    }

    
    internal class Program
    {
        static void Main(string[] args)
        {
            Human h= new Human();
            h.ToSee();
            if (h.eyes.ToLower()=="maggie")
            { 
                Console.WriteLine("order the food");
                h.ToSmell();
                if (h.nose.ToLower()== "good")
                {
                    Console.WriteLine("Eat the food.");
                    h.ToTaste();
                    if (h.tongue.ToLower()== "tasty")
                    {
                        Console.WriteLine("Enjoy to the deepest");
                    }
                    else
                    {
                        Console.WriteLine("Change the chef");
                    }
                }
                else
                {
                    Console.WriteLine("The food is Foul");
                }
            }
            else
            {
                Console.WriteLine("Going to next Restaurant");
            }


            Console.ReadLine();


        }
    }
}
