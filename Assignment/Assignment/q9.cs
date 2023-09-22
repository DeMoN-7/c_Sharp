using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class q9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your string: ");
            string str = Console.ReadLine();
            int count = 0;
            string largest = "";
            for (int i = 0; i < str.Length; i++)
            {
                string temp = "";
                int c = 0;
                while (i < str.Length && str[i] != ' ')
                {
                    temp += str[i];
                    c++;
                    i++;
                }
                if (c > count)
                {
                    largest = temp;
                    count = c;
                }
            }
            Console.WriteLine("Largest word is: " + largest);
        }
    }
}
