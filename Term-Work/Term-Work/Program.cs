using System;

class Palindrome
{
    static void Main(string[] args)
    {
        int num = 0;
        int rev = 0;
        int rem = 0;
        int temp = 0;
        Console.WriteLine("Enter number:");
        num = int.Parse(Console.ReadLine());
        temp = num;
        while (num > 0)
        {
            rev = (rev * 10) + (num % 10);
            num = num / 10;
        }
        if (temp == rev)
            Console.WriteLine("Number is Palindrome");
        else
            Console.WriteLine("Number is not Palindrome");
        Console.ReadLine();
    }
}
