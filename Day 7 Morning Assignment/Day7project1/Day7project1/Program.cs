using System;
using System.Collections.Generic;


namespace Day7project1
{
    internal class Program
    {
        class Employee
        {
            public int Id;
            public string Name;
            public int salary;

            public void ReadEmployee()
            {
                Console.WriteLine("Enter ID: ");
                Id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Name: ");
                Name = Console.ReadLine();

                Console.WriteLine("Enter Salary: ");
                salary = Convert.ToInt32(Console.ReadLine());

            }
            public void PrintEmployee()
            {
                Console.WriteLine($"Id = {Id}, Name = {Name}, Salary = {salary}");
            }
            

        }
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.ReadEmployee();    
            emp1.PrintEmployee();

            Console.ReadLine();
      
        }
    }
}
