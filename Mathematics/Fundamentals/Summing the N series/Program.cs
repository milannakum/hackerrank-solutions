using System;

namespace Summing_the_N_series
{
    class Program
    {
        /*
         * Complete the summingSeries function below.
         */
        static ulong summingSeries(ulong n)
        {
            return (n * n);
        }

        static void Main(string[] args)
        {
            progStart:

            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                ulong n = Convert.ToUInt64(Console.ReadLine());

                ulong result = (summingSeries(n) % 1000000007);

                Console.WriteLine(result);
            }

            goto progStart;
        }
    }
}
