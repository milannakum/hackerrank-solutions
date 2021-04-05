using System;

namespace Viral_Advertising
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int res = 2;
            int total = 5;
            for(int i = 1; i < n; i++)
            {
                total = (int)(total / 2) * 3;
                res += (int)(total / 2);
            }
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
