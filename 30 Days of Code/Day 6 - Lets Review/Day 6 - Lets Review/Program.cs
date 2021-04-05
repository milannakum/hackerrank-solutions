using System;
using System.Text;

namespace Day_6___Lets_Review
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                string s = Console.ReadLine();
                StringBuilder s1 = new StringBuilder(""), s2 = new StringBuilder("");
                bool odd = false;
                for (int j = 0; j < s.Length; j++)
                {
                    if (odd)
                        s2.Append(s[j]);
                    else
                        s1.Append(s[j]);
                    odd = !odd;
                }
                Console.WriteLine(s1 + " " + s2);
            }
        }
    }
}
