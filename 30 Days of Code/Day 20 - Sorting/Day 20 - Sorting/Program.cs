using System;

namespace Day_20___Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            int numberOfSwaps = 0;

            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < n - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int[] tmp = swap(a[j], a[j + 1]);
                        a[j] = tmp[0];
                        a[j + 1] = tmp[1];
                        numberOfSwaps++;
                    }
                }
                if (numberOfSwaps == 0)
                    break;
            }

            Console.WriteLine($"Array is sorted in {numberOfSwaps} swaps.");
            Console.WriteLine($"First Element: {a[0]}");
            Console.WriteLine($"Last Element: {a[n - 1]}");
        }

        static int[] swap(int v1, int v2)
        {
            if (v1 >= v2)
                return new int[] { v2, v1 };
            else
                return new int[] { v1, v2 };
        }
    }
}