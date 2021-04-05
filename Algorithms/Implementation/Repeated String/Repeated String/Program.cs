using System;
using System.Linq;

namespace Repeated_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            long n = Convert.ToInt64(Console.ReadLine());
            long k = (n - (n % s.Length)) / s.Length;
            long no = s.Count(c => c == 'a') * k;
            int temp = (int)(n % s.Length);
            string tempS = s.Substring(0, temp);
            no += tempS.Count(c => c == 'a');
            Console.WriteLine(no);
            Console.ReadKey();
        }
    }
}
