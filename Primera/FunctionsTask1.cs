using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Primera
{

    class FunctionsTask1
    {
        private int[] arr;

        public FunctionsTask1(int[] arr) { this.arr = arr; }

        public int IsSorted()
        {
            int countAsc = 0, countDesc = 0;

            for (int i = 0; i < arr.Length - 1; ++i)
            {
                if (this.arr[i] < this.arr[i + 1])
                    ++countAsc;
                else if (this.arr[i] > this.arr[i + 1])
                    ++countDesc;
            }

            return countDesc == arr.Length - 1 ? -1 : countAsc == arr.Length - 1 ? 1 : 0;
        }
    }

    class SortingTest
    {
        public void Test(int[] a)
        {
            FunctionsTask1 s = new FunctionsTask1(a);
            int res = s.IsSorted();
            System.Console.WriteLine(res == -1 ? "Массив отсортирован по убыванию" : res == 1 ? "Массив отсортирован по возрастанию" : "Массив не отсортирован");
        }
    }

    //class SortTest
    //{

    //    public IQueryable<FunctionsTask1> SortArray<TKey>(Expression<Func<FunctionsTask1, TKey>> sortBy, SortOrder typeSort, IQueryable<FunctionsTask1> array)
    //    {
    //        return typeSort switch
    //        {
    //            SortOrder.Desc => array.OrderByDescending(sortBy),
    //            _ => array.OrderBy(sortBy),
    //        };
    //    }
    //    array = SortTest(a => a.Name, SortOrder.Asc, authors);
    //}
}
