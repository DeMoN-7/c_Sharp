using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 
                = { 1, 2, 3,4,3, 2, 1 };
            bool tt = true;
            for (int i = 0; i < arr1.Length / 2; i++)
            {
                if (arr1[i] != arr1[arr1.Length - 1 - i])
                {
                    tt = false;
                    break;
                }
            }
            Console.WriteLine("Array 1 is a palindrome: " + tt);

        }
    }
}

/* pallindrome 
 * array prime    
 * third largest 
 * sum of number from string
 * sort 012*/