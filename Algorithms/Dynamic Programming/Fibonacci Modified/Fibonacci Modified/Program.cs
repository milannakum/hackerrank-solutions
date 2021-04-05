using System;

namespace Fibonacci_Modified
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tmp = Console.ReadLine().Split(' ');
            ulong t1 = Convert.ToUInt64(tmp[0]), t2 = Convert.ToUInt64(tmp[1]), n = Convert.ToUInt64(tmp[2]);
            Console.WriteLine(calc(t1, t2, n - 1));
            Console.ReadKey();
        }

        static ulong calc(ulong t1, ulong t2, ulong n)
        {
            if(n == t1)
                return t1;
            if(n == t2)
                return t2;
            return calc(t1, t2, n - 2) + (ulong)Math.Pow(calc(t1, t2, n - 1), 2);
        }
    }
}