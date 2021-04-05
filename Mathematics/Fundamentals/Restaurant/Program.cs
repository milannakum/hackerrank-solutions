using System;

namespace Restaurant
{
    class Program
    {
        static int getGcd(int a, int b)
        {
            if (a == 0) return b;
            return getGcd(b % a, a);
        }

        /*
         * Complete the restaurant function below.
         */
        static int restaurant(int l, int b)
        {
            if (l == b) return 1;
            else if (l > b && l % b == 0) return (l / b);
            else if (b > l && b % l == 0) return (b / l);

            int gcd = getGcd(l, b);
            return Math.Min(l, b);
        }

        static void Main(string[] args)
        {
            progStart:

            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] lb = Console.ReadLine().Split(' ');

                int l = Convert.ToInt32(lb[0]);

                int b = Convert.ToInt32(lb[1]);

                int result = restaurant(l, b);

                Console.WriteLine(result);
            }

            goto progStart;
        }
    }
}
