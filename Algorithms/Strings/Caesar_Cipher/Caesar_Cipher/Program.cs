using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            string s = Console.ReadLine();
            int k = Convert.ToInt32(Console.ReadLine());

            while (k > 25)
            {
                k -= 26;
            }

            char[] ch = s.ToCharArray();
            int[] ich = new int[ch.Count()];
            for (int i = 0; i < ich.Count(); i++)
            {
                ich[i] = Convert.ToInt32(ch[i]);

                ch[i] = Convert.ToChar(abc(ich[i], k));
            }
            Console.WriteLine(new string(ch));

            Console.ReadKey();
        }

        public static int abc(int ij, int k)
        {
            if (ij > 64 && ij <= 90 - k)
            {
                ij += k;
            }
            else if (ij > 90 - k && ij < 91)
            {
                int z = 90 - ij;
                int y = k - z;
                ij = 64 + y;
            }
            else if (ij > 96 && ij <= 122 - k)
            {
                ij += k;
            }
            else if (ij > 122 - k && ij < 123)
            {
                int z = 122 - ij;
                int y = k - z;
                ij = 96 + y;
            }

            return ij;
        }
    }
}
