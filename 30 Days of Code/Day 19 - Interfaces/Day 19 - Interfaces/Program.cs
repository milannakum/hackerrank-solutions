using System;

namespace Day_19___Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            AdvancedArithmetic myCalculator = new Calculator();
            int sum = myCalculator.divisorSum(n);
            Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum);
        }
    }

    class Calculator : AdvancedArithmetic
    {
        public int divisorSum(int n)
        {
            int res = 0;
            for (int i = 1; i <= n; i++)
                if (n % i == 0)
                    res += i;
            return res;
        }
    }

    public interface AdvancedArithmetic
    {
        int divisorSum(int n);
    }
}