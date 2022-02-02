using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// ============================================
// Author : Nanam Vaishnavi
// Purpose : Class Department using 4 loops.
// =============================================

namespace Day8Project4
{
    class Department
    {
        public int id;
        public string name;
        public int empcount;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Department> department = new List<Department>()
            {
               new Department(){id=520, name="SoftwareDeveloper", empcount=60 },
               new Department() {id=522, name="Tester",empcount=40},
                new Department() {id=523, name="Scrum Master",empcount=70},
                new Department() {id=524, name="SQL Develloper",empcount=80 },
                new Department() {id=525, name="C# Developer",empcount=20},
            };

            Console.WriteLine("==================================================================");

            // forloop
            for (int i=0;i<department.Count;i++)
            {
                if(department[i].empcount>50)
                    Console.WriteLine($"id={department[i].id},name={department[i].name}");
            }
            Console.WriteLine("==================================================================");

            // foreach loop
            foreach(var d in department)
            {
                if(d.empcount>50)
                    Console.WriteLine($"id={d.id}, name={d.name}");
            }

            Console.WriteLine("==================================================================");

            // Lambda Expression
            department.ToList().Where(d => d.empcount > 50).ToList().ForEach(d => Console.WriteLine($"id={d.id},name={d.name}"));

            Console.WriteLine("==================================================================");

            // LinQ
            var res = from d in department
                      where d.empcount > 50
                      select d;
            res.ToList().ForEach(d => Console.WriteLine($"id={d.id}, name={d.name}"));

            Console.WriteLine("==================================================================");
            Console.ReadLine();
        }
    }
}
