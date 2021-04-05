using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsExploration
{
    class Program
    {
        static void Main(string[] args)
        {
            l:

            string S = Console.ReadLine();
            int c = 0;
            int x = S.Count() / 3;
            for (int i = 0; i < S.Count(); i += 3)
            {
                char[] ch = (S.Substring(i, 3)).ToCharArray();
                if (ch[0] != 'S')
                    c++;
                if (ch[1] != 'O')
                    c++;
                if (ch[2] != 'S')
                    c++;
            }
            Console.WriteLine(c);

            goto l;
        }
    }
}
