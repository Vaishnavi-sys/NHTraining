using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer;
// ****************************************
// Author : Nanam Vaishnavi
// Purpose : MyClientApp in Console Application
// ****************************************

namespace MyClientApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int ch;
            string choice;
            do
            {
                
                Console.WriteLine("***************************************");
                Console.WriteLine("Employee Management Application");
                Console.WriteLine("***************************************");
                Console.WriteLine("1. Add Employee: ");
                Console.WriteLine("2. Search Employee By ID: ");
                Console.WriteLine("3. Search Employee By Name: ");
                Console.WriteLine("4. Display All Employee: ");
                Console.WriteLine("***************************************");
                Console.WriteLine("Enter Your choice");
                ch = Convert.ToInt32(Console.ReadLine());
                
                switch (ch)
                {
                    case 1:
                        AddEmployee();
                        break;
                    case 2:
                        SearchEmployeeById();
                        break;
                    case 3:
                        SearchEmployeeByName();
                        break;
                    case 4:
                        DisplayAllEmployees();
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
                Console.WriteLine("***************************************");
                Console.WriteLine("Do you want to continue(y/n)");
                choice = Console.ReadLine();
            } while (choice == "y");
        }
        public static void AddEmployee()
        {
            int id, salary, age;
            string name;
            Console.WriteLine("Enter ID: ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name: ");
            name = (Console.ReadLine());
            Console.WriteLine("Enter Salary: ");
            salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Age: ");
            age = Convert.ToInt32(Console.ReadLine());

            var result = EmployeeBLL.AddEmployee(id, name, salary, age);

            Console.WriteLine("***************************************");
            if (result)
                Console.WriteLine("Employee Details Saved Successfully");
            else
                Console.WriteLine("Error Occured");
        }
        public static void SearchEmployeeById()
        {
           
            int id;
            Console.WriteLine("Enter ID: ");
            id = Convert.ToInt32(Console.ReadLine());

            var result = EmployeeBLL.GetEmployeeById(id);
            Console.WriteLine("***************************************");
            if (result.Count == 0)
                Console.WriteLine("No records exists with this ID ");
            else
            
                result.ForEach(r => Console.WriteLine(r));           
        }
        public static void SearchEmployeeByName()
        {
            string name;
            Console.WriteLine("Enter Name: ");
            name = Console.ReadLine();

            var result = EmployeeBLL.GetEmployeeByName(name);
            if (result.Count == 1)
                result.ForEach(r => Console.WriteLine(r));
            
            else
            {
                Console.WriteLine("No records exists with this NAME ");
            }
        }
        public static void DisplayAllEmployees()
        {
            var result = EmployeeBLL.GetAllEmployees();
            foreach (var employee in result)
            {
                Console.WriteLine(employee);
            }
                
        }


    }
}


