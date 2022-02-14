using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
// **********************************
// Author : Nanam Vaishnavi
// Purpose : Modify the quiz application to save the name and score in the flat file.
//*****************************************

namespace Day15Project5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score = 0, ans;
            string name;
            Console.WriteLine("Enter your name");
            name = Console.ReadLine();
            Console.WriteLine("**************");
            Console.WriteLine("Hi{0},Welcome to quiz by Vaishnavi", name);
            Console.WriteLine("**************");

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
            
            

            string lines = "Name: " + name + "\n\n   score: " + score.ToString();
            File.WriteAllText("QuizScore.txt", lines);
            // File stream to read the file content
            FileInfo fi = new FileInfo(@"QuizScore.txt");

            string fullFileName = fi.FullName;
            //Console.WriteLine("File Name : {0}",fullFileName);

            /*Open file for Read\Write
            FileStream fs = fi.Open(FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read);*/

           // Create object of StreamReader by passing FileStream object on which it needs to operates on
            //StreamReader sr = new StreamReader(fs);

            /*Use ReadToEnd method to read all the content from file
            string fileContent = sr.ReadToEnd();
            Console.WriteLine(fileContent);*/

            //Close StreamReader object after operation
            //sr.Close();
            //fs.Close();

            /*StreamWriter sr = new StreamWriter("C:\\Users\\Vaishnavi\\Desktop", true);
            name = Console.ReadLine();
            sr.WriteLine(name);
            score = Convert.ToInt32(Console.ReadLine());
            sr.WriteLine(score);*/

            Console.WriteLine("Thank you for taking the quiz. Admin will let you know the score");

            Console.ReadLine();

        }
    }
    }
    
