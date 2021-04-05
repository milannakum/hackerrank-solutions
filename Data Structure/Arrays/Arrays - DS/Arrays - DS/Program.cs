using System;
using System.Collections.Generic;
using System.Linq;

namespace Arrays___DS
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string s = Console.ReadLine();
            string[] sAr = s.Split(' ');
            Array.Reverse(sAr);
            Console.WriteLine(string.Join(" ", sAr));
            Console.ReadKey();
        }
    }
}
