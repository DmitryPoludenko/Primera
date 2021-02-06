using System;

namespace Primera
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(MultArithmeticElements(5, 3, 4));
        }

        static long MultArithmeticElements (long a, long t, long n)
        {
            long b = 0;
            long sum = 1;

            for (long i = 0; i < n; i++)
            {
                b = a + t * i;
                sum *= b;
            }

            return sum;
        }
    }
}
