using System;
using System.Collections.Generic;

namespace Sparse_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Dictionary<string, int> dict = new Dictionary<string, int>();
            for(int i = 0; i < n; i++)
            {
                string temp = Console.ReadLine();
                if(dict.ContainsKey(temp))
                    dict[temp]++;
                else
                    dict.Add(temp, 1);
            }
            int q = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < q; i++)
            {
                string temp = Console.ReadLine();
                if(dict.ContainsKey(temp))
                    Console.WriteLine(dict[temp]);
                else
                    Console.WriteLine("0");
            }
            Console.ReadKey();
        }
    }
}