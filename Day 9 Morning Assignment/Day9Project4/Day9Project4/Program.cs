using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//********************************************
// Author : Nanam Vaishnavi
// Purpose : Employee Class Constructor 
//********************************************

namespace Day9Project4
{
    class Employee
    {
        public int id;
        public string name;
        public int salary;
        public static string company = "NationsBenefits";

        public Employee()
        {
            this.id = 0;
            this.name = null;

        }

        public Employee(int eid, string ename, int esalary)
        {
            id = eid;
            name = ename;
            salary = esalary;

        }
        public void ReadData()
        {
            Console.WriteLine("Enter Employee ID: ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Employee Salary: ");
            salary = Convert.ToInt32(Console.ReadLine());

            company = "NationsBenifts";
        }
        public void PrintData()
        {
            Console.WriteLine($"Id:{id}, Name:{name}, Salary:{salary}, Company={company}");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(1, "Vaishnavi", 50000);
            emp.PrintData();


            Console.ReadLine();
        }
    }
}
