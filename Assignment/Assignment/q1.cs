using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class q1
    {
        static void Main(string[] args)
        {
            string s = "ABCDCBA";
            char[] chars = s.ToCharArray();
            int x = chars.Length - 1;
            int k = 0;
            for (int i = 0; i <= x / 2; i++)
            {
                if (!(chars[i] == chars[x - i]))
                {
                    k = 1;
                    Console.WriteLine("not pallindrome");
                    break;
                }
            }
            if (k == 0)
            {
                Console.WriteLine("pallindrome");
            }
        }
    }
}
