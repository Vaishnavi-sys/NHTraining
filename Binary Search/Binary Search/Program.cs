using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search
{
    internal class BSearch
    {
        static void Main(string[] args)
        {
            BSearch search = new BSearch();
            int[] search_list = new int[] { 2, 3, 9, 20, 68, 25, 74, 62, 50, 80 };

            int b, res;
            Console.WriteLine("Array Elements: ");
            foreach (int i in search_list)
                Console.Write(i + " ");
            Console.WriteLine();

            Array.Sort(search_list);
            Console.WriteLine("Sorted Array: ");
            foreach (int i in search_list)
                Console.Write(i + " ");
            Console.WriteLine();

            Console.WriteLine("Enter a value to search: ");
            b = Convert.ToInt32(Console.ReadLine());

            res = search.search_value(search_list, b);

            if (res > 0)
                Console.WriteLine("Target Value " + b + " is found at position " + (res + 1));
            else
                Console.WriteLine("Target bot found!");
            Console.ReadLine();
        }
        int search_value(int[] arr, int target)
        {
            int low, high, mid;
            low = 0;
            high = arr.Length - 1;
            mid = (low + high) / 2;
            while (low <= high)
            {
                if (arr[mid] == target)
                    return mid + 1;
                else
                    if (target < arr[mid])
                    high = mid - 1;
                else
                    low = mid + 1;
                mid = (low + high) / 2;
            }
            return -1;
            Console.ReadLine();
        }





    }
    }

