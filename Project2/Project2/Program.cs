using System;
using System.Linq;

public class Class1
{
  
        static void Main(String[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int x = arr.Length - 1;
            int temp = arr[x];
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i]);
        }
        Console.WriteLine();
        for (int i = x; i >= 1; i--)
            {
           
                arr[i] = arr[i - 1];
            }
            arr[0] = temp;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
            Console.ReadLine();
        }
    
}



