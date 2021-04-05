using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kangaroo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens_x1 = Console.ReadLine().Split(' ');
            int x1 = Convert.ToInt32(tokens_x1[0]);
            int v1 = Convert.ToInt32(tokens_x1[1]);
            int x2 = Convert.ToInt32(tokens_x1[2]);
            int v2 = Convert.ToInt32(tokens_x1[3]);

            bool a = procTry(x1, v1, x2, v2);

            if (a == true)
                Console.WriteLine("YES");
            if (a == false)
                Console.WriteLine("NO");

            Console.ReadKey();
        }

        static bool procTry(int x1, int v1, int x2, int v2)
        {
            if (v1 < v2)
                return false;
            else
            {
                int sum1 = x1;
                int sum2 = x2;
                while (sum1 < sum2)
                {
                    sum1 = sum1 + v1;
                    sum2 = sum2 + v2;
                    if (sum1 == sum2)
                        return true;
                }
                return false;
            }
        }
    }
}
