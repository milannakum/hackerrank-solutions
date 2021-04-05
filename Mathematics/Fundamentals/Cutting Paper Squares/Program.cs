using System;

namespace Cutting_Paper_Squares
{
    class Program
    {
        // Complete the solve function below.
        static long solve(long n, long m)
        {
            return ((n * m) - 1);
        }

        static void Main(string[] args)
        {
            progStart:

            string[] nm = Console.ReadLine().Split(' ');

            long n = Convert.ToInt64(nm[0]);

            long m = Convert.ToInt64(nm[1]);

            long result = solve(n, m);

            Console.WriteLine(result);

            goto progStart;
        }
    }
}
