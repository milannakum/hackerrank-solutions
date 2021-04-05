using System;

namespace Intro_to_Tutorial_Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            int v = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
            string[] tmp = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(tmp, Convert.ToInt32);
            int res = Array.IndexOf(ar, v);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}