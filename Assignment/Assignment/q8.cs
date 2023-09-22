using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class q8
    {
        static bool anagram(string a, string b)
        {
            if (a.Length != b.Length)
                return false;
            for (int i = 0; i < a.Length; i++)
            {
                int count1 = 0;
                int count2 = 0;
                for (int j = 0; j < b.Length; j++)
                {
                    if (Char.IsWhiteSpace(a[i]) == false)
                    {
                        if (a[i] == a[j])
                            count1++;
                        if (a[i] == b[j])
                            count2++;
                    }
                }
                if (count1 != count2)
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first string: ");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter your second string: ");
            string str2 = Console.ReadLine();
            if (anagram(str1.Replace(" ", ""), str2.Replace(" ", "")))
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
        }
    }
}
