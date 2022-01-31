using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_int
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int>();
            int temp;
            int s1 = 0, s2 = 0, s3 = 0;

            // read 5 values from user
            for(int i =1;i<=5;i++)
            {
                Console.WriteLine("Enter any value: ");
                temp = Convert.ToInt32(Console.ReadLine());
                data.Add(temp);
            }
            Console.WriteLine("========================================");
            //for loop
            for (int i = 0; i < data.Count; i++)
            {
                s1 =s1+data[i];
            }
            Console.WriteLine("=========================================");
            //Foreach loop
            foreach (var d in data)
            {
                s2 = s2 + d;
            }

            //LAmbda expression
            data.ForEach(d => s3 = s3 + d);

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);

            Console.ReadLine();
        }
    }
}


       

