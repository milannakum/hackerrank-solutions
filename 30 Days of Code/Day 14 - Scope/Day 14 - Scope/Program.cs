using System;
using System.Linq;

namespace Day_14___Scope
{
    class Difference
    {
        private int[] elements;
        public int maximumDifference;

        public Difference(int[] a)
        {
            elements = a;
        }

        public void computeDifference()
        {
            Array.Sort(elements);
            maximumDifference = Math.Abs(elements[0] - elements[elements.Length - 1]);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Convert.ToInt32(Console.ReadLine());

            int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            Difference d = new Difference(a);

            d.computeDifference();

            Console.Write(d.maximumDifference);
        }
    }
}
