using System;

namespace Alternating_Characters
{
    class Program
    {
        static int alternatingCharacters(string s)
        {
            // Complete this function
            char[] ch = s.ToCharArray();
            int count = 0;
            for(int i = 0; i < ch.Length - 1; i++)
            {
                if(ch[i] == ch[i + 1])
                {
                    count++;
                }
            }
            return count;
        }

        static void Main(String[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());
            for(int a0 = 0; a0 < q; a0++)
            {
                string s = Console.ReadLine();
                int result = alternatingCharacters(s);
                Console.WriteLine(result);
                Console.ReadKey();
            }
        }
    }
}
