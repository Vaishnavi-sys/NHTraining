using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaishnaviLibrary;

namespace day16Project3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mathematics m = new Mathematics();
            m.ReadData();
            Console.WriteLine(m.GetFactorial());
            Console.WriteLine("==================================");
            Physics p = new Physics();
            Console.WriteLine(p.FinalVelocity(5,3,1));
            Console.WriteLine("==================================");
            Chemistry c = new Chemistry();
            Console.WriteLine(c.Benzene());
            Console.WriteLine(c.Water());
            Console.WriteLine("==================================");
            Console.ReadLine();
           


            Console.ReadLine();
        }
    }
}
