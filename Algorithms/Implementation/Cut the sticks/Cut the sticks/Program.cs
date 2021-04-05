using System;
using System.Collections.Generic;
using System.Linq;

namespace Cut_the_sticks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            string[] tmp = Console.ReadLine().Split(' ');
            List<int> a = Array.ConvertAll(tmp, Convert.ToInt32).ToList();
            a.Sort();
            while(a.Count != 0)
            {
                Console.WriteLine(a.Count);
                int k = a[0];
                for(int i = 0; i < a.Count; i++)
                    a.RemoveAll(t => t == k);
            }
            Console.ReadKey();
        }
    }
}