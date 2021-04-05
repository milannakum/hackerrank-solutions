using System;

namespace Day_29___Bitwise_AND
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                string[] tokens_n = Console.ReadLine().Split(' ');
                int n = Convert.ToInt32(tokens_n[0]);
                int k = Convert.ToInt32(tokens_n[1]);
                int max = 0;
                for (int b = 2; b <= n; b++)
                    for (int a = 1; a < b; a++)
                    {
                        int x = a & b;
                        if (x < k && x > max)
                        {
                            max = x;
                            if (x == k - 1)
                                break;
                        }
                    }
                Console.WriteLine(max);
            }
        }
    }
}