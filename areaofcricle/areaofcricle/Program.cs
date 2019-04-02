using System;

namespace areaofcricle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of cirlce:");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Area of Circle={0}", length *length);
        }
    }
}
