using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Primera
{
    class ArrayRectangles
    {
        private readonly Rectangle[] rectangle_array;

        //int ifZero;
        //public int IfZero
        //{
        //    get
        //    {
        //        var ifZero = rectangle_array.Where(x => x == 0).Count();
        //        return ifZero;
        //    }
        //}
        public ArrayRectangles(int n)
        {
            rectangle_array = new Rectangle[n];
        }

        public ArrayRectangles(IEnumerable<Rectangle> rectangles)
        {
            rectangle_array = rectangles.ToArray();
        }

        public ArrayRectangles(Rectangle[] rectangle_array)
        {
            this.rectangle_array = new Rectangle[rectangle_array.Length];

            for(int i = 0; i < rectangle_array.Length; i++)
            {
                if (rectangle_array[i] != null)
                    this.rectangle_array[i] = new Rectangle(rectangle_array[i].GetSideA(), rectangle_array[i].GetSideB());
            }
        }

        public bool AddRectangle(Rectangle rectangle)
        {
            for (int i = 0; i < rectangle_array.Length; i++)
            {
                if (rectangle_array[i] == null)
                {
                    rectangle_array[i] = rectangle;
                    return true;
                }
            }
            return false;
        }

        public Int32 NumberMaxArea()
        {
            int indexOfMaxRectArea = 0;
            int maxSquare = 0;
            for(int i = 0; i < rectangle_array.Length; i++)
            {
                if (rectangle_array[i].Area() > maxSquare)
                {
                    indexOfMaxRectArea = i;
                    maxSquare = rectangle_array[i].Area();
                }
            }
            return indexOfMaxRectArea;
        }

        public Int32 NumberMinPerimeter()
        {
            int indexOfMinRectPerimeter = 0;
            int maxPerimeter = int.MaxValue;
            for (int i = 0; i < rectangle_array.Length; i++)
            {
                if (rectangle_array[i].Perimeter() < maxPerimeter)
                {
                    indexOfMinRectPerimeter = i;
                    maxPerimeter = rectangle_array[i].Perimeter();
                }
            }
            return indexOfMinRectPerimeter;
        }

        public Int32 NumberSquare()
        {
            int count = 0;
            for (int i = 0; i < rectangle_array.Length; i++)
            {
                if (rectangle_array[i].IsSquare())
                {
                    count++;
                }
            }   
            return count;
        }

    }
}
