using System;

namespace Day_9___Recursion
{
    class Program
    {
        static int factorial(int n)
        {
            if (n == 1)
                return 1;
            return n * factorial(n - 1);
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(factorial(n));
        }
    }
}
