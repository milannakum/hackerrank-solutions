using System;
using System.Linq;

namespace BirthdayCakeCandles
{
    class Program
    {
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] ar_temp = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
            int result = birthdayCakeCandlesA(n, ar);
            Console.WriteLine(result);
        }

        static int birthdayCakeCandlesA(int n, int[] ar)
        {
            // Complete this function
            int x = ar.Max();
            int count = 0;
            foreach(int y in ar)
            {
                if(y == x)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
