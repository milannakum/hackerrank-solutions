using System;
using System.Collections.Generic;
using System.Linq;

namespace Pair_Sums
{
    class Program
    {
        static long largestValue(long[] A)
        {
            long res = 0;
            var g = A.ToList();

            int index = 0;
            for (long i = A.LongLength - 1; i >= 0; i--)
            {
                if (A[i] > 0)
                {
                    index = (int)i;
                    break;
                }
            }
            if (index < A.LongLength - 1)
                g.RemoveRange(index, (int)A.LongLength - 1);

            index = 0;
            for (long i = 0; i < A.LongLength; i++)
            {
                if (A[i] > 0)
                {
                    index = (int)i;
                    break;
                }
            }
            if (index > 0)
                g.RemoveRange(0, index);


            var x = GetAllCombos(g);
            x.RemoveAll(z => z.Count != 2);
            var y = new List<long>();
            foreach (var item in x)
            {
                y.Add(item[0] * item[1]);
            }
            res = y.Sum();

            return res;
        }

        static void Main(String[] args)
        {
            long n = Convert.ToInt64(Console.ReadLine());
            string[] A_temp = Console.ReadLine().Split(' ');
            long[] A = Array.ConvertAll(A_temp, Int64.Parse);
            long result = largestValue(A);
            Console.WriteLine(result);
        }

        public static List<List<T>> GetAllCombos<T>(List<T> list)
        {
            List<List<T>> result = new List<List<T>>();

            result.Add(new List<T>());
            result.Last().Add(list[0]);
            if (list.Count == 1)
                return result;

            List<List<T>> tailCombos = GetAllCombos(list.Skip(1).ToList());
            tailCombos.ForEach(combo =>
            {
                result.Add(new List<T>(combo));
                combo.Add(list[0]);
                result.Add(new List<T>(combo));
            });
            return result;
        }
    }
}
