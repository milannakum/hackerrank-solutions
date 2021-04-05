using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamelCasing
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            int res = 1;
            char[] ch = s.ToCharArray();
            int[] aa = new int[ch.Count()];

            for (int i = 0; i < ch.Count(); i++)
            {
                aa[i] = Convert.ToInt32(ch[i]);
                if (aa[i] >= 65 && aa[i] <= 90)
                    res++;
            }
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
