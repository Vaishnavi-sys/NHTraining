using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int>();

            int sum = 0;
            data.Add(10);
            data.Add(20);
            data.Add(40);
            data.Add(30);
            data.Add(sum);

            foreach(var d in data)
            {
                sum = sum + d;
            }
            Console.WriteLine(sum);

            Console.ReadLine();

        }
    }
}
