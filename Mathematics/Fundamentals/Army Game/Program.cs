using System;

namespace Army_Game
{
    class Program
    {
        /*
         * Complete the gameWithCells function below.
         */
        private static int GameWithCells(int n, int m)
        {
            /*
             * Write your code here.
             */
            int a = 1, b = 1;
            if (n > 2) a = (n % 2 == 0 ? (n / 2) : ((n + 1) / 2));
            if (m > 2) b = (m % 2 == 0 ? (m / 2) : ((m + 1) / 2));
            return (a * b);
        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            progStart:
            string[] nm = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nm[0]);

            int m = Convert.ToInt32(nm[1]);

            int result = GameWithCells(n, m);

            Console.WriteLine(result);

            goto progStart;
            //Console.ReadLine();
            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
