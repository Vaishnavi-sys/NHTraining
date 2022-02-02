using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//*****************************************
// AUTHOR : Nanam Vaishnavi
// Purpose : List of employees
//****************************************

namespace Day8Project2
{
    class Employee
    {
        public int id;
        public string name;
        public int salary;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee() {id=501, name ="Vaishnavi", salary=5000},
                new Employee() {id=502, name="Rathika", salary=4000},
                new Employee() {id=503, name="Prashanth", salary=8000 },
                new Employee() {id=504, name ="Sushma", salary=6000},
                new Employee() {id=505, name ="Abhiram", salary=3000},
            };

            Console.WriteLine("*****************************************************");

            // forloop
            for (int i=0; i<employees.Count; i++)
            {
                Console.WriteLine($"id={employees[i].id}, name={employees[i].name}, salary={employees[i].salary}");
            }

            Console.WriteLine("*****************************************************");

            // foreach
            foreach (var e in employees)
            {
                Console.WriteLine($"id={e.id}, name={ e.name}, salary={e.salary}");
            }

            Console.WriteLine("*****************************************************");

            // Lambda Expression
            employees.ToList().ForEach(e => Console.WriteLine($"id={e.id}, name={e.name}, salary={e.salary}"));
            Console.WriteLine("*****************************************************");

            // LinQ
            var result = from e in employees
                         select e;
            result.ToList().ForEach(e => Console.WriteLine($"id={e.id}, name={e.name}, salary={e.salary}"));

            Console.WriteLine("*****************************************************");

            Console.ReadLine();

        }
    }
}
