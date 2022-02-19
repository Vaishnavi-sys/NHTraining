
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
            int id;
            Console.WriteLine("Enter  ID: ");
            id = Convert.ToInt32(Console.ReadLine());


            XmlDocument doc= new XmlDocument();
            doc.Load("G:\\XML files\\Project1.xml");


            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                bool isMatch = false;
                foreach (XmlNode cnode in node.ChildNodes)
                {
                    if (cnode.Name == "ID")
                    {
                        if (cnode.InnerText == id.ToString())
                        {
                            isMatch = true;
                        }
                    }
                    if(cnode.Name == "Name" && isMatch)
                    {
                        Console.WriteLine(cnode.InnerText);
                        break;
                    }
                        
                 }
            }
            Console.ReadLine();

        }

    }
}

