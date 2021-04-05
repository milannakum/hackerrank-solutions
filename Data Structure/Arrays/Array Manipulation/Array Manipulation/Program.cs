using System;
using System.Linq;

namespace Array_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            long n = Convert.ToInt64(tokens_n[0]);
            long m = Convert.ToInt64(tokens_n[1]);
            long[] ar = new long[n + 1];
            /*
            for(long i = 0; i < n; i++)
                ar[i] = 0;
            */
            for(long a0 = 0; a0 < m; a0++)
            {
                string[] tokens_a = Console.ReadLine().Split(' ');
                long a = Convert.ToInt64(tokens_a[0]);
                long b = Convert.ToInt64(tokens_a[1]);
                long k = Convert.ToInt64(tokens_a[2]);

                ar[a] += k;
                if((b + 1) <= n) ar[b + 1] -= k;

                /*for(long i = a; i <= b; i++)
                    ar[i - 1] += k;
                    */
            }
            long max = 0, x = 0;
            for(long i = 1; i <= n; i++)
            {
                x += ar[i];
                if(max < x)
                    max = x;
            }

            Console.WriteLine(max);
            Console.ReadKey();
        }
    }
}
