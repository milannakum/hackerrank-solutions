using System;
using System.Collections.Generic;
using System.Linq;

namespace Bon_Appetit
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] ar_temp = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
            int b = Convert.ToInt32(Console.ReadLine());
            string result = bonAppetit(n, k, b, ar);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        static string bonAppetit(int n, int k, int b, int[] ar)
        {
            string s;
            List<int> l = new List<int>(ar);
            l.Remove(ar[k]);
            int i = l.Sum() / 2;
            if(b == i)
                s = "Bon Appetit";
            else
            {
                s = (b - i).ToString();
            }

            return s;
        }
    }
}
