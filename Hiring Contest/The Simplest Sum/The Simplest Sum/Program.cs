using System;

namespace The_Simplest_Sum
{
    class Program
    {
        static long simplestSum(long k, long a, long b)
        {
            long res = 0;
            if ((k > b) && (k > a))
                res = b - a + 1;
            else
                for (; a <= b; a++)
                    res += f(k, a);

            if (res > 1000000006)
                res = res % (1000000007);

            return res;
        }

        static long f(long k, long n)
        {
            long sum = 0;
            for (long i = 1; i <= n; i++)
            {
                sum += i;
                i *= k;
            }
            return sum;
        }

        static void Main(String[] args)
        {
            long q = Convert.ToInt64(Console.ReadLine());
            for (long a0 = 0; a0 < q; a0++)
            {
                string[] tokens_k = Console.ReadLine().Split(' ');
                long k = Convert.ToInt64(tokens_k[0]);
                long a = Convert.ToInt64(tokens_k[1]);
                long b = Convert.ToInt64(tokens_k[2]);
                long result = simplestSum(k, a, b);
                Console.WriteLine(result);
            }
        }


        /*
        static void Main(String[] args) {
        long q = Convert.ToInt64(Console.ReadLine());
        for (long a0 = 0; a0 < q; a0++)
        {
            
            string[] tokens_k = Console.ReadLine().Split(' ');
                long k = Convert.ToInt64(tokens_k[0]);
                long a = Convert.ToInt64(tokens_k[1]);
                long b = Convert.ToInt64(tokens_k[2]);
            
            long res = 0;
            if ((k > b) && (k > a))
                res = b - a + 1;
            else
                for (; a <= b; a++)
                    for (long i = 1; i <= a; i++)
                    {
                        res += i;
                        i *= k;
                    }

            if (res > 1000000006)
                res = res % (1000000007);
            
            Console.WriteLine(res);
        }
    }
        */
    }
}