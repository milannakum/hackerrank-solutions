using System;

namespace Picking_Numbers
{
    class Program
    {
        static int pickingNumbers(int[] a)
        {
            int res = 0;
            int[] count = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                count[i] = 0;
                for (int j = 0; j < a.Length; j++)
                    if (i == j)
                        continue;
                    else if ((a[i] == a[j]) || (a[i] == (a[j] + 1)))
                        count[i]++;

                if (count[i] > res)
                    res = count[i];
            }

            return res + 1;
        }

        static void Main(string[] args)
        {
            Console.ReadLine();
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            Console.WriteLine(pickingNumbers(a));
            Console.ReadKey();
        }
    }
}