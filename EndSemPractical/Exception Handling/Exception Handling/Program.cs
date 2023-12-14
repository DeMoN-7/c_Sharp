using System;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {

                Console.WriteLine("Enter Number 1: ");
                int x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Number 2: ");
                int z = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(x/z);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e);
                Console.ReadLine();
            }
            finally
            {
                Console.WriteLine("Finally Worked Succesfully");
                Console.ReadLine();
            }

        }
    }
}
