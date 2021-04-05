using System;

namespace Drawing_Book
{
    class Program
    {
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int p = Convert.ToInt32(Console.ReadLine());
            int res = Math.Min(p / 2, (n - p) / 2);
            if (n % 2 == 0)
                res = Math.Min(p / 2, (n + 1 - p) / 2);
            Console.WriteLine(res);
        }
    }
}