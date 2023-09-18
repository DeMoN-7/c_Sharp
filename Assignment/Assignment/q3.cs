using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class q3
    {
        static void Main(string[] args)
        {
            string vowels = "aeiouAEIOU";
            string str = Console.ReadLine();
            string res = "";
            foreach(char c in str)
            {
                if (!vowels.Contains(c.ToString()))
                    {
                    res += c;
                }
            }
            Console.WriteLine("Before removing element:"+str+"\nAfter removing vowel:"+res);
            
        }
    }
}
