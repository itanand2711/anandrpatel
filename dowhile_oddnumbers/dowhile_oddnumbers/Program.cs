using System;

namespace dowhile_oddnumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            do
            {
                if(i%2 != 0)
                {
                    Console.WriteLine("Odd number is {0}",i);
                }
                i++;
            } while (i<50);
        }
    }
}
