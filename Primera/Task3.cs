using System;
using System.Collections.Generic;
using System.Text;

namespace Primera
{
    class Task3: Program
    {
        public static long MultArithmeticElements(long a, long t, long n)
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
