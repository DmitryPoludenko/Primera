using System;
using System.Collections.Generic;
using System.Text;

namespace Primera
{
    class Rectangle
    {
        private Int32 sideA;
        private Int32 sideB;

        public Rectangle(int a, int b)
        {
            this.sideA = a;
            this.sideB = b;
        }

        public Rectangle(int a)
        {
            sideA = a;
            sideB = 5;
        }

        public Rectangle()
        {
            sideA = 4;
            sideB = 3;
        }

        public int GetSideA()
        {
            return sideA;
        }

        public int GetSideB()
        {
            return sideB;
        }

        public int Area()
        {
            return sideA * sideB;
        }

        public int Perimeter()
        {
            return 2 * (sideA + sideB);
        }

        public bool IsSquare()
        {
            if (sideA == sideB)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ReplaceSides ()
        {
            int tmp;
            tmp = sideA;
            sideA = sideB;
            sideB = tmp;

        }
    }
}
