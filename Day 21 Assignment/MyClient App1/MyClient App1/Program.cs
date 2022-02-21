using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClient_App1.ServiceReference1;

namespace MyClient_App1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            WebService1SoapClient ob = new WebService1SoapClient();
            Console.WriteLine(ob.Factorial(5));
            Console.WriteLine(ob.Add(5,8));
            Console.WriteLine(ob.Mul(6,9));
            Console.WriteLine(ob.Div(25,5));

            Console.ReadLine();
        }
    }
}
