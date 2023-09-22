using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class q5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your a string: ");
            string str = Console.ReadLine();
            string newstr = "";
            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                if (Char.IsLetter(c))
                    newstr += c;
            }
            Console.WriteLine("Old String: " + str + "\nNew String: " + newstr);
        }
    }
}
