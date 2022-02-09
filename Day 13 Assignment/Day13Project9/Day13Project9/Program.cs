using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Project9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack <int> data = new Stack<int>();
            {
                data.Push(26);
                data.Push(20);
                data.Push(37);
                Console.WriteLine(data.Count);
                Console.WriteLine(data.Pop());
                Console.WriteLine(data.Count);
                Console.WriteLine(data.Pop());


                Console.ReadLine();
            }
        }
    }
}
