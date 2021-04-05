using System;

namespace Minimum_Absolute_Difference_in_an_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            string[] tmp = Console.ReadLine().Split(' ');
            long[] arr = Array.ConvertAll(tmp, Int64.Parse);
            Array.Sort(arr);
            long min = long.MaxValue;
            for(int i = 0; i < arr.Length - 1; i++)
                min = Math.Min(min, Math.Abs(arr[i] - arr[i + 1]));
            Console.WriteLine(min);
            Console.ReadKey();
        }
    }
}