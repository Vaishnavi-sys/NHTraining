using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linear_Search
{
    internal class Search1
    {
        static void Main(string[] args)
        {
            Search1 search = new Search1();
            int[] search_list = new int[] { 3, 5, 12, 5, 28, 16, 20, 35, 9, 40};

            int p, res;
            Console.WriteLine("Enter a value to search: ");
            p = Convert.ToInt32(Console.ReadLine());

            res = search.LinearSearch(search_list, p);

            if (res>0)

                Console.WriteLine("The target value " + p + "is found at position " + res);
            else
                Console.WriteLine("Target Not Found");

            Console.ReadLine();

        }
        int LinearSearch(int[] arr, int target)
        {
            for(int i=0;i<arr.Length;i++)
            {
                if (target == arr[i])
                    return (i + 1);
            }

            return -1;

            Console.ReadLine();

        }
    }
}
