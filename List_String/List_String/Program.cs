using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <string> data = new List<string>();
            data.Add("Vaishu");
            data.Add("Rathika");
            data.Add("Aruna");
            data.Add("Sindhu");

            //for loop
            for(int i=0; i<data.Count;i++)
            {
                Console.WriteLine(data[i]);
            }
             
            //foreach loop
            foreach(var d in data)
            {
                Console.WriteLine(d);
            }

            //Lambda Expression
            data.ForEach(p => Console.WriteLine(p));


            Console.ReadLine();
        }
    }
}
