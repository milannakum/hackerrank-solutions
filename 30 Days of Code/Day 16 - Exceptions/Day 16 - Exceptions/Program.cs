using System;

namespace Day_16___Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            try
            {
                Console.WriteLine(int.Parse(s));
            }
            catch
            {
                Console.WriteLine("Bad String");
            }
        }
    }
}