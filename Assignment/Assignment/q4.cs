using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class q4
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            string str2= " ",str3="";
            
            foreach (char c in str1)
            {
                if (!str2.Contains(c.ToString()))
                {
                    str3 += c;
                }
            }
            Console.WriteLine(str3);
            Console.ReadLine();
        }
    }
}
