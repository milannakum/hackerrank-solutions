using System;

namespace Day_2___Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            double meal_cost = Convert.ToDouble(Console.ReadLine());
            int tip_percent = Convert.ToInt32(Console.ReadLine());
            int tax_percent = Convert.ToInt32(Console.ReadLine());
            int res = (int)Math.Round(meal_cost * (tip_percent + tax_percent + 100) / 100);
            Console.WriteLine("The total meal cost is {0} dollars.", res);
            Console.ReadLine();
        }
    }
}