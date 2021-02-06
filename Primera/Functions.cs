using System;
using System.Collections.Generic;
using System.Text;

namespace Primera
{
    class Functions: Program
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

        public static double SumGeometricElements (double a, double t, double alim)
        {
            double sum = a;
            while (a > alim)
            {
                a -= a * t;
                if (a < alim)
                {
                    break;
                }
                sum += a;
            }
            //Returns the integer without rounding --> (int)sum;
            //Returns the integer with rounding --> Convert.ToInt32(sum);
            return sum;
        }
    }
}
