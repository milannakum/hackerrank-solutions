using System;

namespace Breaking_the_Records
{
    class Program
    {
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] s_temp = Console.ReadLine().Split(' ');
            int[] s = Array.ConvertAll(s_temp, Int32.Parse);
            int[] result = getRecord(s);
            Console.WriteLine(String.Join(" ", result));
            Console.ReadKey();
        }

        static int[] getRecord(int[] s)
        {
            int high = 0, low = 0, highCount = 0, lowCount = 0;
            for(int i = 0; i < s.Length; i++)
            {
                if(i == 0)
                {
                    high = s[i];
                    low = s[i];
                }
                else
                {
                    if(s[i] > high)
                    {
                        high = s[i];
                        highCount++;
                    }
                    else if(s[i] < low)
                    {
                        low = s[i];
                        lowCount++;
                    }
                }
            }

            int[] res = new int[2] { highCount, lowCount };

            return res;
        }
    }
}
