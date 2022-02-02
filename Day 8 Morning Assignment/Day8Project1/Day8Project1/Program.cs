using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int>() { 56, 45, 44, 37, 55, 60, 78 };

            Console.WriteLine("======================================");

            // for loop
            for (int i=0;i<data.Count;i++)
            {
                if (data[i] % 2 == 0)
                    Console.WriteLine(data[i]);

            }
            Console.WriteLine("======================================");
            // foreach loop
            foreach(var d in data)
            {
                if(d%2==0)
                    Console.WriteLine(d);
            }

            Console.WriteLine("======================================");

            // Lambda Expression
            data.Where(d=>d%2==0).ToList().ForEach(e => Console.WriteLine(e));

            Console.WriteLine("======================================");

            // LinQ
            var res = from d in data
                      where d % 2 == 0
                      select d;
            res.ToList().ForEach(e => Console.WriteLine(e));

            Console.WriteLine("======================================");

            Console.ReadLine();           
            
        }
    }
}
