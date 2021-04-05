using System;

namespace Strange_Grid_Again
{
    class Program
    {
        /*
     * Complete the strangeGrid function below.
     */
        static long StrangeGrid(long r, long c)
        {
            /*
             * Write your code here.
             */
            long a = (r % 2 == 0) ? ((10 * ((r / 2) - 1)) + 1) : (10 * (((r + 1) / 2) - 1));
            long b = ((c - 1) * 2);
            return (a + b);
        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            progStart:
            string[] rc = Console.ReadLine().Split(' ');

            long r = Convert.ToInt64(rc[0]);

            long c = Convert.ToInt64(rc[1]);

            long result = StrangeGrid(r, c);

            Console.WriteLine(result);
            goto progStart;
            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
