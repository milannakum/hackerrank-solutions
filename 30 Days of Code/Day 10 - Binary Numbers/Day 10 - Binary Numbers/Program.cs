using System;

namespace Day_10___Binary_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Convert.ToString(Convert.ToInt32(Console.ReadLine()), 2);
            int count = 0, maxcount = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '1')
                {
                    count++;
                    if (maxcount < count)
                        maxcount = count;
                }
                else
                    count = 0;
            }
            Console.WriteLine(maxcount);
        }
    }
}