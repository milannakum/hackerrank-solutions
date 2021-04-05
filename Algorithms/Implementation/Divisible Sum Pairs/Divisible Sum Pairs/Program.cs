using System;

namespace Divisible_Sum_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] ar_temp = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
            int result = divisibleSumPairs(n, k, ar);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        static int divisibleSumPairs(int n, int k, int[] ar)
        {
            int res = 0;
            for(int i = 0; i < n; i++)
                for(int j = 0; j < n; j++)
                    if((i < j) && ((ar[i] + ar[j]) % k == 0))
                        res++;

            return res;
        }
    }
}
