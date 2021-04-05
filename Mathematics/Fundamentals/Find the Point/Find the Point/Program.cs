using System;

namespace Find_the_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                int[] a = Array.ConvertAll(s, Convert.ToInt32);
                Console.WriteLine("{0} {1}", (a[2] + a[2] - a[0]), (a[3] + a[3] - a[1]));
            }
            Console.ReadKey();
        }
    }
}