using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
//**************************************************
// Author : Nanam Vaishnavi
// Purpose : Business Logic Layer in Class Library
// **************************************************


namespace BusinessLogicLayer
{
    public class EmployeeBLL
    {
        public static bool AddEmployee(int empId, string empName, int empSalary, int empAge)
        {
            var result = EmployeeDAL.AddEmployee(empId, empName, empSalary, empAge);
            
            return result;
        }
        public static List<String> GetEmployeeById(int id)
        {
            var result = EmployeeDAL.GetEmployeeById(id);

            return result;
        }
        public static List<String> GetEmployeeByName(string name)
        {
            var result = EmployeeDAL.GetEmployeeByName(name);   
             
            return result;
        }
        public static string[] GetAllEmployees()
        {
            var result = EmployeeDAL.GetAllEmployees();

            return result;
        }       
    }
}
