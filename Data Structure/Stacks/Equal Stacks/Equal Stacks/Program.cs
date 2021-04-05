using System;
using System.Collections.Generic;
using System.Linq;

namespace Equal_Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            string[] h1_temp = Console.ReadLine().Split(' ');
            int[] h1 = Array.ConvertAll(h1_temp, Int32.Parse);
            string[] h2_temp = Console.ReadLine().Split(' ');
            int[] h2 = Array.ConvertAll(h2_temp, Int32.Parse);
            string[] h3_temp = Console.ReadLine().Split(' ');
            int[] h3 = Array.ConvertAll(h3_temp, Int32.Parse);
            List<int> hl1 = new List<int>(h1);
            List<int> hl2 = new List<int>(h2);
            List<int> hl3 = new List<int>(h3);
            int res1 = h1.Sum();
            int res2 = h2.Sum();
            int res3 = h3.Sum();
            while(hl1.Count > 0 && hl2.Count > 0 && hl3.Count > 0)
            {
                if(res1 == res2 && res2 == res3)
                    break;
                else
                {
                    if(res1 >= res2 && res1 > res3 || res1 > res2 && res1 >= res3)
                    {
                        res1 -= hl1[0];
                        hl1.RemoveAt(0);
                    }
                    else if(res2 >= res3 && res2 > res1 || res2 > res3 && res2 >= res1)
                    {
                        res2 -= hl2[0];
                        hl2.RemoveAt(0);
                    }
                    else if(res3 >= res1 && res3 > res2 || res3 > res1 && res3 >= res2)
                    {
                        res3 -= hl3[0];
                        hl3.RemoveAt(0);
                    }
                }
            }
            if(hl1.Count > 0 && hl2.Count > 0 && hl3.Count > 0 && res1 == res2 && res2 == res3)
                Console.WriteLine(res1);
            else
                Console.WriteLine("0");
            Console.ReadKey();
        }
    }
}
