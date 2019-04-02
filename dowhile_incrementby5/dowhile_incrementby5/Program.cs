using System;

namespace dowhile_incrementby5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            do
            {
                Console.WriteLine("Value of i={0}", i);
                i = i + 5;
            } while (i < 50);
        }
    }
}
