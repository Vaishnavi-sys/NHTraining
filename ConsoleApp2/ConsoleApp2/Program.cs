using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Student
    {
        public int id;
        public string name;
        public int age;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.id = 556;
            s.name = "Vaishnavi";
            s.age = 21;

            Console.WriteLine($"Id = {s.id}, Name = {s.name}, Age = {s.age}");

            Console.ReadLine();
        }
    }
}
