
using System;

    public delegate void DEE(int x, int y);
class delll
{

    public void summ(int x, int y)
    {
        Console.WriteLine(x+y);
    }
}

namespace EndSemPractice_Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            delll x = new delll();
            DEE dx = new DEE(x.summ);
            dx(1, 2);
            Console.Read();
        }
    }
}
