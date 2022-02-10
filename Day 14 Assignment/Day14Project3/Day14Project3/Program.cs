using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// *******************************************************
// Author : Nanam Vaishnavi
// Purpose : Auto - implemented property
// ******************************************************

namespace Day14Project3
{
    class Customer
    {
        private string name;
        private int id;
        private string email;
        
        public void SetId(int Id)
        {
            this.id = Id;
        }
        public int GetId()
        {
            return this.id; 
        }

        public void SetName(string Name)
        {
            this.name = Name;                   
        }
        public string GetName()
        {
            return this.name;
        }

        public void SetEmail(string Email)
        {
            this.email =Email;
        }
        public string GetEmail()
        {
            return this.email;
        }


    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer();
            c.SetId(501);
            c.SetName("Vaishnavi");
            c.SetEmail("abcd@gmail.com");
            Console.WriteLine(c.GetId());
            Console.WriteLine(c.GetName());
            Console.WriteLine(c.GetEmail());


            Console.ReadLine();

        }
    }
}
