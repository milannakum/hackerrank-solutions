using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_L_Letter_Mystery
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] s = new string[n];
            string[] r = new string[n];
            for (int i = 0; i < n; i++)
            {
                s[i] = Console.ReadLine();
                char[] charArray = s[i].ToCharArray();
                Array.Reverse(charArray);
                r[i] = new string(charArray);
                while (s[i] != r[i])
                {

                }
            }
        }
    }
}
