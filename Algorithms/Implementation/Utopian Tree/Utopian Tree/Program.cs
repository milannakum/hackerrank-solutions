using System;

namespace Utopian_Tree
{
    class Program
    {
        static int utopianTree(int n)
        {
            if (n == 0)
                return 1;
            if (n == 1)
                return 2;

            int res = 2;
            for (int i = 2; i <= n; i++)
                if (i % 2 == 1)
                    res *= 2;
                else if (i % 2 == 0)
                    res++;

            return res;
        }

        static void Main(String[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
                Console.WriteLine(utopianTree(Convert.ToInt32(Console.ReadLine())));
        }
    }
}