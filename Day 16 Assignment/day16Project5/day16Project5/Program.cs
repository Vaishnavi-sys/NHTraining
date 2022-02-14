using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day16Project5
{
    class Palindrome
    {
        int n, rev, s = 0, temp;
        /// <summary>
        /// for read data
        /// </summary>
        public void ReadData()
        {
            Console.WriteLine("Enter the Number: ");
            n = Convert.ToInt32(Console.ReadLine());
        }
        /// <summary>
        /// to find palindrome
        /// </summary>
        public void GetPalindrome()
        {
            temp = n;
            while (n > 0)
            {
                rev = n % 10;
                s = (s * 10) + rev;
                n = n / 10;
            }
            if (temp == s)
                Console.WriteLine("Palindrome",n);
            else
                Console.WriteLine("Not Palindrome",n);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Palindrome p = new Palindrome();
            p.ReadData();
            p.GetPalindrome();

            Console.ReadLine(); 

        }
    }
}
