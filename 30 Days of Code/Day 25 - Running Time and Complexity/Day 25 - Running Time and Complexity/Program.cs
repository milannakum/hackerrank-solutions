using System;

namespace Day_25___Running_Time_and_Complexity
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = Convert.ToInt64(Console.ReadLine());
            for (long i = 0; i < n; i++)
            {
                long val = Convert.ToInt64(Console.ReadLine());
                for (long j = 2; j <= val / j; j++)
                    if (val % j == 0)
                    {
                        val = 1;
                        break;
                    }
                Console.WriteLine(val == 1 ? "Not prime" : "Prime");
            }
        }
    }
}