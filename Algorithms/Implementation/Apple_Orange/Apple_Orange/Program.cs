using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apple_Orange
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens_s = Console.ReadLine().Split(' ');
            string[] tokens_a = Console.ReadLine().Split(' ');
            string[] tokens_m = Console.ReadLine().Split(' ');
            string[] apple_temp = Console.ReadLine().Split(' ');
            string[] orange_temp = Console.ReadLine().Split(' ');

            int s = Convert.ToInt32(tokens_s[0]);
            int t = Convert.ToInt32(tokens_s[1]);
            
            int a = Convert.ToInt32(tokens_a[0]);
            int b = Convert.ToInt32(tokens_a[1]);
            
            int m = Convert.ToInt32(tokens_m[0]);
            int n = Convert.ToInt32(tokens_m[1]);
            
            int[] apple = Array.ConvertAll(apple_temp, Int32.Parse);
            int[] orange = Array.ConvertAll(orange_temp, Int32.Parse);

            int resA = 0, resO = 0;

            for (int i = 0; i < m; i++)
            {
                if (((a + apple[i] >= s) && (a + apple[i] <= t)) || ((a + apple[i] <= s) && (a + apple[i] >= t)))
                    resA++;
            }
            for (int i = 0; i < n; i++)
            {
                if (((b + orange[i] >= s) && (b + orange[i] <= t)) || ((b + orange[i] <= s) && (b + orange[i] >= t)))
                    resO++;
            }
            Console.WriteLine(resA + "\n" + resO);

            Console.ReadKey();
        }
    }
}
