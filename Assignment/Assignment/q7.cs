using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class q7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your a string: ");
            string str = Console.ReadLine();
            char[] c = str.ToCharArray();
            string ano = "" + Char.ToUpper(c[0]);
            for (int i = 1; i < c.Length - 1; i++)
            {
                if (Char.IsWhiteSpace(c[i + 1]) && i + 2 < str.Length)
                {
                    ano += Char.ToUpper(c[i]);
                    ano += " ";
                    ano += Char.ToUpper(c[i + 2]);
                    i += 2;
                }
                else
                    ano += c[i];
            }
            ano += Char.ToUpper(c[c.Length - 1]);
            Console.WriteLine("Old String: " + str + "\nNew String: " + ano);
        }
    }
}
