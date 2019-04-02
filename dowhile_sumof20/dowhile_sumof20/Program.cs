using System;

namespace dowhile_sumof20
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int sum = 0;
            do
            {
                sum = sum + i;
                i++;
            } while (i <= 20);
            Console.WriteLine("Sum of first 20 number is {0}",sum);
        }
    }
}
