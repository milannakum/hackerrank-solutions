using System;
using System.Linq;

namespace Two_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetIn(new System.IO.StreamReader
                (Console.OpenStandardInput(), Console.InputEncoding, false, bufferSize: 4096));
            int q = Convert.ToInt32(Console.ReadLine());
            for(int a0 = 0; a0 < q; a0++)
            {
                string s1 = Console.ReadLine();
                string s2 = Console.ReadLine();
                string result = twoStrings(s1, s2);
                Console.WriteLine(result);
            }
            Console.ReadKey();
        }

        static string twoStrings(string s1, string s2)
        {
            for(int i = 0; i < 26; i++)
                if(s1.Contains((char)(i + 97)) && s2.Contains((char)(i + 97)))
                    return "YES";
            return "NO";
        }
    }
}