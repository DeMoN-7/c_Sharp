using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
     class q2
    {
        static void Main(string[] args)
        {
            int space=0, cons=0, vowel = 0;
            string str = Console.ReadLine();
            str = str.ToLower();
            char[] chars = str.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i]==' ')
                {
                    space ++;
                }
                else if (chars[i]=='a' || chars[i] == 'e' || chars[i] == 'i' || chars[i] == 'o' || chars[i] == 'u')
                {
                    vowel++;
                }
                else
                {
                    cons++;
                }
               
            }
            Console.WriteLine("Space=" + space + "\nVowel=" + vowel + "\n Consonant=" + cons);
            Console.Read();
        }
    }
}
