using System;
using System.Linq;

namespace Funny_String
{
    class Program
    {
        static void Main(string[] args)
        {l:
            int n = Convert.ToInt32(Console.ReadLine());
            string[] S = new string[n];

            for (int i = 0; i < n; i++)
            {
                S[i] = Console.ReadLine();

                bool b = abc(S[i]);

                if (b)
                    Console.WriteLine("Funny");
                else
                    Console.WriteLine("Not Funny");
            }

            goto l;
        }

        public static bool abc(string S)
        {
            bool b = true;

            char[] Sch = S.ToCharArray();
            char[] Rch = Sch.Reverse().ToArray();

            int[] iSch = new int[Sch.Count()];
            int[] iRch = new int[Sch.Count()];

            for (int i = 0; i < Sch.Count(); i++)
            {
                iSch[i] = Convert.ToInt32(Sch[i]);
                iRch[i] = Convert.ToInt32(Rch[i]);
            }
            for (int i = 1; i < Sch.Count(); i++)
            {
                if (Math.Abs(iSch[i - 1] - iSch[i]) != Math.Abs(iRch[i - 1] - iRch[i]))
                {
                    b = false;
                }
            }

            return b;
        }
    }
}
