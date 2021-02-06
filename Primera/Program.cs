using System;

namespace Primera
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine(Functions.MultArithmeticElements(5, 3, 4));
            Console.WriteLine(Functions.SumGeometricElements(100, 0.5, 20));

        }
    }
}
