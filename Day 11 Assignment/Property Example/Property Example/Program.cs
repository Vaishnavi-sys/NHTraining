using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// ****************************************************
// Author : Nanam Vaishnavi
// Purpose : class Employee using properties
// ****************************************************
namespace Property_Example
{
    class Employee
    {
        private int id;
        private string name;
        private string designation;
        private int salary;

        public int Id
        {
            get { return id; }
            set { id = value; } 
        }
        public string Name
        {
            get { return name; }
            set { name = value; }

        }
        public string Designation
        {
            set { designation = value; }
        }
        public int Salary
        {
            get
            {
                salary = (designation == "Software Employee") ? 30000 : 60000;
                return salary;
            }

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Designation = "M";
            Console.WriteLine(emp.Salary);

            Console.ReadLine(); 
        }
    }
}
