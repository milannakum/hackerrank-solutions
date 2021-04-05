using System;

namespace Handshake
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < T; a0++)
            {
                int N = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Fact(N - 1));
            }
            Console.ReadKey();
        }

        static long Fact(long n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;
            else
                return n + Fact(n - 1);
        }
    }
}