using System;

namespace Maximum_Draws
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                if (n == 1)
                    Console.WriteLine(2);
                else
                    Console.WriteLine(n + 1);
            }
            Console.ReadKey();
        }
    }
}