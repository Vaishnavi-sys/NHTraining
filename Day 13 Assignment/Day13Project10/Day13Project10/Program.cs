using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// ********************************************
// Author : Nanam Vaishnavi
// Purpose : Usage of Queue
// *********************************************

namespace Day13Project10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue <int> data = new Queue<int>();
            data.Enqueue(56);
            data.Enqueue(45);
            data.Enqueue(50);
            Console.WriteLine(data.Count);
            Console.WriteLine(data.Dequeue());
           

            Console.ReadLine();

        }
    }
}
