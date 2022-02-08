using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_snippets
{
    public static void Main(string[] args)
    {
        int[] tab = new int[5] { 2, 7, 3, 9, 5 };
        int index = 5;
        AccessElement(tab, index);
    }
    public static void AccessElement(int[] tab, int index)
    {
        Console.WriteLine("AccessElement {0}: {1}", index, tab[index]);
        Console.ReadLine();
    }
}


      


