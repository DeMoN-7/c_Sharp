using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace November_Work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* string[] arr = { "Aman", "Chaman", "Ayush", "Coomshal" };
             foreach (string c in arr)
             { 
                 Console.WriteLine(c.Length +" "+ c[c.Length - 1]);
             }
             Console.ReadKey();
            */
            int[] arr = { 7, 5, 5, 2, 7, 2, 5 };
            int n = 0;
            foreach(int x in arr)
            {
                n = n ^ x;
            }
            Console.WriteLine(n);
            Console.ReadKey();
        }
    }
}
