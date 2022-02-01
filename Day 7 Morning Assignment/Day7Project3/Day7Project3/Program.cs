using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Project3
{
    class Employee
    {
        public int empid;
        public string name;
        public int salary;
       
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.empid = 26;
            emp.name = "Vaishu";
            emp.salary = 30000;

            //{empid =26; name ="vaishu, age= 21, salary=30000"};
            Console.WriteLine($"empid= {emp.empid}, name={emp.name}, salary={emp.salary}");
            Console.ReadLine();

        }
    }
}
