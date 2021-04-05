using System;
using System.Collections.Generic;
using System.Linq;

namespace Dynamic_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string tI= Console.ReadLine();
            string[] tII = tI.Split(' ');
            int n = Convert.ToInt32(tII[0]);
            int q = Convert.ToInt32(tII[1]);
            string[] sAr = new string[q];
            int[,] iDAr = new int[q, 3];
            int lastAnswer = 0;
            List<int>[] seq = new List<int>[n];
            for(int i = 0; i < q; i++)
            {
                sAr[i] = Console.ReadLine();
                string[] tempS = sAr[i].Split(' ');
                for(int j = 0; j < 3; j++)
                    iDAr[i, j] = Convert.ToInt32(tempS[j]);
                int x = iDAr[i, 1];
                int y = iDAr[i, 2];
                if(iDAr[i, 0] == 1)
                {
                    if(seq[(x ^ lastAnswer) % n] == null)
                        seq[(x ^ lastAnswer) % n] = new List<int>();
                    seq[(x ^ lastAnswer) % n].Add(y);
                }
                else
                {
                    int k = (x ^ lastAnswer) % n;
                    lastAnswer = seq[k][y % seq[k].Count];
                    Console.WriteLine(lastAnswer);
                }
            }

            Console.ReadKey();
        }
    }
}
