using System;

namespace Between_Two_Sets
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int m = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            string[] b_temp = Console.ReadLine().Split(' ');
            int[] b = Array.ConvertAll(b_temp, Int32.Parse);
            int total = getTotalX(a, b);
            Console.WriteLine(total);
            Console.ReadKey();
        }

        static int getTotalX(int[] a, int[] b)
        {
            Array.Sort(a);
            Array.Sort(b);
            int count = 0, maxA = a[a.Length - 1], minB = b[0];
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    if (a[j] % a[0] != 0)
                        break;
                    else
                        count++;
                }
            }
            return count;
        }
    }
}