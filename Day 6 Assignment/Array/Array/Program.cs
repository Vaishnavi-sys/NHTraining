using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList data = new ArrayList();

            int s = 0;
            data.Add(10);
            data.Add(20);
            data.Add(40);
            
            foreach(var d in data)
            {
                s = s + (int)d;
            }
            Console.WriteLine(s);

            Console.ReadLine();
        }
    }
}
