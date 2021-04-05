using System;
using System.Linq;

namespace Cloudy_Day
{
    class Program
    {
        static long maximumPeople(long[] p, long[] x, long[] y, long[] r)
        {
            long res = 0;
            if (y.Length == 1)
                res = p.Sum();

            return res;
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] p_temp = Console.ReadLine().Split(' ');
            long[] p = Array.ConvertAll(p_temp, Int64.Parse);
            string[] x_temp = Console.ReadLine().Split(' ');
            long[] x = Array.ConvertAll(x_temp, Int64.Parse);
            int m = Convert.ToInt32(Console.ReadLine());
            string[] y_temp = Console.ReadLine().Split(' ');
            long[] y = Array.ConvertAll(y_temp, Int64.Parse);
            string[] r_temp = Console.ReadLine().Split(' ');
            long[] r = Array.ConvertAll(r_temp, Int64.Parse);
            long result = maximumPeople(p, x, y, r);
            Console.WriteLine(result);
        }
    }
}
