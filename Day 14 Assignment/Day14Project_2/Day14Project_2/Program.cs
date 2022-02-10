
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// **************************************************
// Author : Nanam Vaishnavi
// Purpose : To illustrate normal properties
// ***************************************************

namespace Day14Project_2
{
    public class Employee
    {
        private int id;
        public string name;
        public int  salary;

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Id = 501;
            emp.Name = "Vaishnavi";
            emp.Salary = 30000;
            Console.Write($"id={emp.Id}, name={emp.Name}, salary= {emp.Salary}");

            Console.ReadLine();
        }
        
    }
}
