using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//*******************************************
// Author : Nanam Vaishnavi
// Purpose : Employee with only properties.
//*******************************************

namespace EmployeeProperties
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public int Salary { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Id = 556;
            Console.WriteLine($"id={emp.Id}");
            emp.Name = "Vaishnavi";
            Console.WriteLine($"name = {emp.Name}");
            emp.Designation = "Programmer";
            Console.WriteLine($"designation = {emp.Designation}");
            emp.Salary = 80000;
            Console.WriteLine($"salary= {emp.Salary}");

            Console.ReadLine();

        }
    }
}
