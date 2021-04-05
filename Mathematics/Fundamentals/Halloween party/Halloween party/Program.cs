using System;

namespace Halloween_party
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                long k = Convert.ToInt64(Console.ReadLine());
                if (k % 2 == 0)
                    Console.WriteLine((k/2) * (k/2));
                else
                    Console.WriteLine(((k-1)/2) * ((k+1)/2));
            }
            Console.ReadKey();
        }
    }
}