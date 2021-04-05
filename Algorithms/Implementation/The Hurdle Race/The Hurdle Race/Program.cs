using System;
using System.Linq;

namespace The_Hurdle_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] height_temp = Console.ReadLine().Split(' ');
            int[] height = Array.ConvertAll(height_temp, Int32.Parse);

            int max = height.Max();
            int res;
            if(max > k)
            {
                res = Math.Abs(k - max);
            }
            else
                res = 0;

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
