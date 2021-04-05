using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GemStones
{
    class Program
    {
        static void Main(string[] args)
        {l:
            int n = Convert.ToInt32(Console.ReadLine());
            string[] s = new string[n];
            int gems = 0;
            for (int i = 0; i < n; i++)
            {
                s[i] = Console.ReadLine();
            }
            
            char[] ch1 = s[0].ToCharArray();
            bool[] b = new bool[n];
            for (int i = 0; i < ch1.Count(); i++)
            {
                for (int j = 1; j < n; j++)
                {
                    b[0] = true;
                    Console.WriteLine("Starting for " + ch1[i]);
                    if (s[j].Contains(ch1[i]))
                    {
                        b[j] = true;
                        int temp = s[j].IndexOf(ch1[i]);
                        Console.WriteLine(temp);
                        Console.WriteLine(s[j][temp]);
                        s[j] = s[j].Remove(temp, 1);
                        Console.WriteLine(s[j]);
                    }
                    else
                    {
                        b[j - 1] = false;
                        Console.WriteLine("Ignore for " + ch1[i] + " in " + s[j]);
                    }
                    b[j] = b[j - 1] && b[j];
                }
                if (b[n - 1])
                {
                    gems++;
                }
            }
            Console.WriteLine(gems);

            goto l;
        }
    }
}
