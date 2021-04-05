using System;
using System.Collections.Generic;
using System.Linq;

namespace Game_of_Two_Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            int g = Convert.ToInt32(Console.ReadLine());
            for(int a0 = 0; a0 < g; a0++)
            {
                string[] tokens_n = Console.ReadLine().Split(' ');
                int n = Convert.ToInt32(tokens_n[0]);
                int m = Convert.ToInt32(tokens_n[1]);
                int x = Convert.ToInt32(tokens_n[2]);
                string[] a_temp = Console.ReadLine().Split(' ');
                int[] a = Array.ConvertAll(a_temp, Int32.Parse);
                string[] b_temp = Console.ReadLine().Split(' ');
                int[] b = Array.ConvertAll(b_temp, Int32.Parse);

                int result = res(a, b, x);
                Console.WriteLine(result);
            }
        }

        static int res(int[] a, int[] b, int x)
        {
            int res = 0, cur = 0;
            Stack<int> sa = new Stack<int>(a);
            Stack<int> sb = new Stack<int>(b);
            while(cur < x)
            {
                int y = sa.Peek();
                int z = sb.Peek();
                if(y <= z)
                {
                    cur += sa.Pop();
                    res++;
                }
                else if(z <= y)
                {
                    cur += sb.Pop();
                    res++;
                }

            }

            return res;
        }
    }
}
