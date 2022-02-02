using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//************************************************
//Author: Nanam Vaishnavi
//Purpose : Management class where salary>30000
//**************************************************

namespace Day8Project5
{
    class Management
    {
        public int id;
        public string name;
        public string designation;
        public int salary;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Management> management = new List<Management>()
            {
                new Management(){id=240, name="Vaishnavi", designation="HR Management", salary =50000 },
                new Management(){id=241, name="Shiva", designation="Process Management", salary=60000},
                new Management(){id=242, name="Abhiram", designation="Managing Management",salary=80000},
                new Management(){id=243, name="JayaTeja", designation="Associates Management", salary=70000 },
                new Management(){id=244, name="Aravind", designation="Operation Management",salary=20000 },


            };
            Console.WriteLine("=====================================================================================");
            // forloop
            for(int i=0;i<management.Count;i++)
            {
                if (management[i].salary > 30000)
                    Console.WriteLine($"id={management[i].id}, name={management[i].name}, designation={management[i].designation},salary={management[i].salary}");

            }

            Console.WriteLine("=====================================================================================");

            // foreach
            foreach (var m in management)
            {
                if (m.salary > 30000)
                    Console.WriteLine($"id ={ m.id}, name={m.name}, designation={m.designation}, salary={m.salary}");
            }

            Console.WriteLine("=====================================================================================");

            // Lambda Expression
            management.ToList().Where(m => m.salary > 30000).ToList().ForEach(m => Console.WriteLine($"id={m.id}, name={m.name}, designation={m.designation}, salary={m.salary}"));

            Console.WriteLine("=====================================================================================");

            // LinQ
            var result = from m in management
                         where m.salary >30000
                         select m;
            result.ToList().ForEach(m => Console.WriteLine($"id={m.id},name={m.name}, designation={m.designation}, salary={m.salary}"));

            Console.WriteLine("=====================================================================================");

            Console.ReadLine();
        }

    }
}
