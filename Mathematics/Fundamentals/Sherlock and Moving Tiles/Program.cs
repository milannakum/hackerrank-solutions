using System;

namespace Sherlock_and_Moving_Tiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lS1S2 = Console.ReadLine().Split(' ');

            ulong l = Convert.ToUInt64(lS1S2[0]);

            long s1 = Convert.ToInt64(lS1S2[1]);

            long s2 = Convert.ToInt64(lS1S2[2]);

            ulong queriesCount = Convert.ToUInt64(Console.ReadLine());

            ulong diff = Convert.ToUInt64(Math.Abs(s1 - s2));
            double r = (diff / Math.Sqrt(2));
            for (ulong queriesItr = 0; queriesItr < queriesCount; queriesItr++)
            {
                ulong queriesItem = Convert.ToUInt64(Console.ReadLine());

                double h = (l - Math.Sqrt(queriesItem));
                double result = (h / r);
                Console.WriteLine(result);
            }
        }
    }
}
