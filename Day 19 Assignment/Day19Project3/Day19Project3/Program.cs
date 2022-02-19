using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
// ***************************
//  Author : Nanam Vaishnavi
// Purpose : C# code to read xml file and print as below information:
// 1,Meganadh,2000
// 2,Raj,3000
// ***************************

namespace Day19Project3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("G:\\XML files\\Project3.xml");

            //XmlNode node = doc.DocumentElement.SelectSingleNode("/Employees/Employee");

            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                string text = node.InnerText; //or loop through its children as well

                Console.WriteLine(text);

            }
            Console.ReadLine();

        }
    }
}

