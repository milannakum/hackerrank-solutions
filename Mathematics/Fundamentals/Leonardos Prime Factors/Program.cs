using System;

namespace Leonardos_Prime_Factors
{
    class Program
    {
        /*
         * Complete the primeCount function below.
         */
        static int primeCount(long n)
        {
            /*
             * Write your code here.
             */
            return 0;
        }

        static void Main(string[] args)
        {
            progStart:
            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                long n = Convert.ToInt64(Console.ReadLine());

                int result = primeCount(n);

                Console.WriteLine(result);
            }

            goto progStart;
        }
    }
}
