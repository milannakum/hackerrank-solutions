using System;

namespace Programming_Contest
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int res = 0;
            string resName = "";
            for (int a0 = 0; a0 < n; a0++)
            {
                string[] tokens_name = Console.ReadLine().Split(' ');
                string name = tokens_name[0];
                int j = Convert.ToInt32(tokens_name[2]) - Convert.ToInt32(tokens_name[1]);

                if (j > res)
                {
                    res = j;
                    resName = name;
                }
            }

            Console.WriteLine("{0} {1}", resName, res);
        }
    }
}
