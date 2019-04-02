using System;

namespace dowhile_1stproject
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            do
            {
                Console.WriteLine("value of i = {0}", i);
                i++;
            } while (i<5);
        }
    }
}
