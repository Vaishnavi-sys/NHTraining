using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7Project4
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
            Employee[] employee = new Employee[5];
            
            employee[0] = new Employee() {id =1,name="Vaishu",salary=5000};
            employee[1] = new Employee() { id = 2, name = "Rathika",salary= 4000 };
            employee[2] = new Employee() { id = 3, name = "Prashanth", salary = 1000 };
            employee[3] = new Employee() { id = 4, name = "Aruna", salary = 2000 };
            employee[4] = new Employee() { id = 5, name = "Pavan", salary = 8000 };

            Console.WriteLine("==========================================================================");

            //forloop
            for (int i=0; i<employee.Length; i++)
            {
                Console.WriteLine($"id={employee[i].id},name={employee[i].name}, salary={employee[i].salary}");

            }
            Console.WriteLine("==========================================================================");
            //foreach loop
            foreach(var e in employee)
            {
                Console.WriteLine($"id ={e.id}, name={e.name}, salary={e.salary}");
            }
            Console.WriteLine("==========================================================================");
            //Lambda Expression
            employee.ToList().ForEach(e => Console.WriteLine($"id{e.id}, name={e.name}, salary={e.salary}"));

           
          
            Console.ReadLine();
            

        }
    };

}       
        
            
            
               
    

