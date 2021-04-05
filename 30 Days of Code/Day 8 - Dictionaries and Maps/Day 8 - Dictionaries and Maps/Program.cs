using System;
using System.Collections.Generic;

namespace Day_8___Dictionaries_and_Maps
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string z;
            Dictionary<string, string> dict = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                string[] tmp = Console.ReadLine().Split(' ');
                dict.Add(tmp[0], tmp[1]);
            }
            while (true)
            {
                string s = Console.ReadLine();
                if (s == null || s == " ")
                    break;
                else if (dict.TryGetValue(s, out z))
                    Console.WriteLine("{0}={1}", s, z);
                else
                    Console.WriteLine("Not found");
            }
        }
    }
}