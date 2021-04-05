using System;

namespace Day_7___Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            Array.Reverse(arr);
            string s = String.Join(' ', arr);
            Console.WriteLine(s);
        }
    }
}
