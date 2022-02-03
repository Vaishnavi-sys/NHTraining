using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    public class BubbleSort1
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[10] { 23, 98, 45, 12, 9, 16, 65, 74, 34, 29 };//Array created with 10 unsorted numbers
            bubblesort(arr, 10);
            int i;
            for (i = 0; i < 10; i++)
                Console.Write(arr[i]+", ");//Printing the array after sorting in descending order
            Console.ReadLine();
        }
        //bubble sort
        static void bubblesort(int[] data, int n)
        {
            int a;
            int b;
            for (a = 0; a < n; a++)
                for (b = n - 1; b > a; b--)
                    if (data[b] > data[b - 1])//Condition to arrange array in descending order
                    {
                        int temp = data[b];
                        data[b] = data[b - 1];
                        data[b - 1] = temp;
                    }
        }
    }
}
