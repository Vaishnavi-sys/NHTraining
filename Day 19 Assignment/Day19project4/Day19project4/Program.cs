
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
// ********************************
// Author : Nanam Vaishnavi
// Purpose : Read Employee ID from user and write C# code to get the employee name from XML for this id.
//*********************************

namespace Day19project4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter  ID: ");
            int n = Convert.ToInt32(Console.ReadLine());


            XmlDocument file = new XmlDocument();
            file.Load("G:\\XML files\\Project4.xml");


            foreach (XmlNode node in file.DocumentElement.ChildNodes)
            {
                foreach (XmlNode node2 in node.ChildNodes)
                {
                    bool id = node2.Name == "ID";
                    bool isIndex = (id == true ? Convert.ToInt32(node2.InnerText) : 0) == n;
                    if (id && isIndex)
                    {
                        Console.WriteLine($"Name of Employee: {node2.NextSibling.InnerText}.");
                    }
                }
            }
            Console.ReadLine();

        }

    }
}

