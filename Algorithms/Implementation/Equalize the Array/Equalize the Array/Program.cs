using System;
using System.Collections.Generic;
using System.Linq;

namespace Equalize_the_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] s = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(s, Int32.Parse);
            List<int> l = new List<int>(ar);
            int maxRepItem = ar.GroupBy(x => x).OrderByDescending(x => x.Count()).First().Key;
            l.RemoveAll(x => x == maxRepItem);

            Console.WriteLine(l.Count());
            Console.ReadKey();
        }
    }
}