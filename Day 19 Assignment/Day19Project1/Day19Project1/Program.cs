using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
// ******************************
// Author : Nanam Vaishnavi
// Purpose : C# code to read xml file and print the content
// ******************************
namespace Day19Project1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("file:///G:/XML%20files/Project1.xml");

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
