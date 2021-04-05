using System;

namespace Combo_Meal
{
    class Program
    {
        // Complete the profit function below.
        static int profit(int b, int s, int c)
        {
            // Return the fixed profit.
            return b + s - c;
        }

        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] bsc = Console.ReadLine().Split(' ');

                int b = Convert.ToInt32(bsc[0]);

                int s = Convert.ToInt32(bsc[1]);

                int c = Convert.ToInt32(bsc[2]);

                int result = profit(b, s, c);

                Console.WriteLine(result);
            }
        }
    }
}
