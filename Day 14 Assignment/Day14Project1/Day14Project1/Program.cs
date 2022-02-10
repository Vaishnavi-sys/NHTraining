using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// ***********************************************************
// Author : Nanam Vaishnavi
// Purpose : Sealed class
// ***********************************************************

namespace Day14Project1
{
    sealed class Police
    {
        public static int Helpline = 100;

        public string Getsecret()
        {
            return "556";
        }
    }
        

    internal class Program
    {
        static void Main(string[] args)
        {
            Police p = new Police();
            Console.WriteLine(p.Getsecret());
            Console.WriteLine(Police.Helpline);
            Console.ReadLine();
        }
    }
}
