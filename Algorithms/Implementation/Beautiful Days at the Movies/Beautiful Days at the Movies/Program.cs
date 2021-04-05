using System;
using System.Collections.Generic;
using System.Linq;

namespace Beautiful_Days_at_the_Movies
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] sAr = s.Split(' ');
            int x = int.Parse(sAr[0]);
            int y = int.Parse(sAr[1]);
            int d = int.Parse(sAr[2]);
            int res = 0;
            for(int i = x; i <= y; i++)
            {
                //string tempS = i.ToString();
                char[] tempC = i.ToString().ToCharArray();
                Array.Reverse(tempC);
                string tempS = new string(tempC);
                int tempI = Int32.Parse(tempS);
                if(Math.Abs(i - tempI) % d == 0)
                    res++;
            }
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
