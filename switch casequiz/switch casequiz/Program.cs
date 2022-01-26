using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_casequiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score = 0, ans;
            string name;
            Console.WriteLine("Enter your name");
            name = Console.ReadLine();
            Console.WriteLine("****************************************");
            Console.WriteLine("Hi{0},Welcome to quiz by Vaishnavi", name);
            Console.WriteLine("****************************************");

            Console.WriteLine("Q1.How many continents are there in the world?");
            Console.WriteLine("1. 3  2. 5  3. 7  4. 9");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 3)
                score += 20;

            Console.WriteLine("Q2.Which is the largest continent in area?");
            Console.WriteLine("1.North America 2. Europe  3.Asia   4.South America ");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 3)
                score += 20;

            Console.WriteLine("Q3.Which of the following is not a continent? ");
            Console.WriteLine("1.Africa 2. Russia  3.Antartica   4.Australia ");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 2)
                score += 20;

            Console.WriteLine("Q4.Which is the smallest continent in area?  ");
            Console.WriteLine("1.Africa 2. Europe  3.South America   4.Australia ");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 4)
                score += 20;

            Console.WriteLine("Q5.Which is the largest continent in population?   ");
            Console.WriteLine("1.Africa 2. Asia  3.South America   4.North America ");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 4)
                score += 20;

            if (score >= 60)
                Console.WriteLine("Congratulations {0}, you got {1}% in this quiz",name,score);
            else
                Console.WriteLine("Sorry {0}, you got only {1}%. Try again");

            Console.ReadLine();

        }

    }
}
