using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            this.salary = 0;
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
            Employee emp = new Employee();
            emp.ReadData();
            emp.PrintData();


            Console.ReadLine();
        }
    }
}
