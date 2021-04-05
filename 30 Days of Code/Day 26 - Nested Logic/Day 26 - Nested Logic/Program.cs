using System;

namespace Day_26___Nested_Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tmp1 = Console.ReadLine().Split(' ');
            string[] tmp2 = Console.ReadLine().Split(' ');
            int y1 = Convert.ToInt32(tmp1[2]), m1 = Convert.ToInt32(tmp1[1]), d1 = Convert.ToInt32(tmp1[0]);
            int y2 = Convert.ToInt32(tmp2[2]), m2 = Convert.ToInt32(tmp2[1]), d2 = Convert.ToInt32(tmp2[0]);
            int fine = 0;
            if (y1 == y2 && m1 == m2 && d1 > d2)
                fine = 15 * (d1 - d2);
            else if (y1 == y2 && m1 > m2)
                fine = 500 * (m1 - m2);
            else if (y1 > y2)
                fine = 10000;
            Console.WriteLine(fine);
        }
    }
}