using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicsLibrary
{
    public class Algebra
    {
        public static int Factorial(int n)
        {

            if (n == 0)
                return 1;
            else if (n > 7)
                return -999;
            else if (n < 0)
                return -9999;
            else
            {
                int fact = 1;
                for (int i = 0; i < n; i++)
                    fact = fact * i;
                return fact;

            }
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static bool IsPalindrome(int n)
        {
            int a, b;
            int rev = 0;
            a = n;
            while(a>0)
            {
                b = a % 10;
                a = a / 10;
                rev = rev * 10 + b;
            }
            
            if(n == rev)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }
        
    }
}
