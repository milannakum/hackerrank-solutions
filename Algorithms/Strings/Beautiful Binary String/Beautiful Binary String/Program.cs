using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beautiful_Binary_String
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string B = Console.ReadLine();
            StringBuilder S = new StringBuilder(B);
            int k = 0;
            for (int i = 1; i < n - 1; i++)
            {
                if (S[i - 1] == '0' && S[i] == '1' && S[i + 1] == '0')
                {
                    S[i + 1] = '1';
                    k++;
                }
            }
            Console.WriteLine(k);

            Console.ReadKey();
        }
    }
}
