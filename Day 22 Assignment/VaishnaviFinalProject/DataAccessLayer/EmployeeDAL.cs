using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// ***************************************
// Author : Nanam Vaishnavi
// Purpose : Data Access Layer  Class Library
// ***************************************

namespace DataAccessLayer
{
    public class EmployeeDAL
    {
        /// <summary>
        /// Filepath
        /// </summary>
        public static string filepath = "F:\\NH\\EmployeesData\\Employee.txt";

        /// <summary>
        /// Add Employee
        /// </summary>
        /// <param name="empId"></param>
        /// <param name="empName"></param>
        /// <param name="empSalary"></param>
        /// <param name="empAge"></param>
        /// <returns></returns>
        public static bool AddEmployee(int empId, string empName, int empSalary, int empAge)
        {
            try
            {
                string textContent = String.Concat(empId,",", empName,",", empSalary,",", empAge);
                File.AppendAllText(filepath, textContent + Environment.NewLine);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        /// <summary>
        /// GetEmployeeById()
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static List<String> GetEmployeeById(int id)
        {
            var allEmployees = File.ReadAllLines(filepath);
            bool isFound = false;

            List<String> employeeFound = new List<string>();
            foreach (string employee in allEmployees)
            {
                var empDetails = employee.Split(',');
                if (Convert.ToInt32(empDetails[0]) == id) 
                {
                    isFound = true;
                    employeeFound.Add(employee);
                    break;
                }

            }
            return employeeFound;
        }
        /// <summary>
        /// GetEmployeeByName
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static List<String> GetEmployeeByName(string name)
        {
            var allEmployees = File.ReadAllLines(filepath);
            bool isFound = false;

            List<String> employeeFound = new List<string>();
            foreach (string employee in allEmployees)
            {
                var empDetails = employee.Split(',');
                if (empDetails[1].Contains(name))
                {

                    employeeFound.Add(employee);

                }
            }
            return employeeFound;
        }
        /// <summary>
        /// GetAllEmployees
        /// </summary>
        /// <returns></returns>
        public static string[] GetAllEmployees()
        {
            var allEmployees = File.ReadAllLines(filepath);
            return allEmployees;
        }
    }
}
