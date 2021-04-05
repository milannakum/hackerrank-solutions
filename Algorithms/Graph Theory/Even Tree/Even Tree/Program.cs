using System;
using System.Collections.Generic;
using System.Linq;

namespace Even_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] token = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(token[0]);
            int m = Convert.ToInt32(token[1]);
            Dictionary<int, int> ls = new Dictionary<int, int>();
            for(int i = 0; i < m; i++)
            {
                string[] tempS = Console.ReadLine().Split(' ');
                int[] tempI = Array.ConvertAll(tempS, Convert.ToInt32);
                if(tempI[1] == 1)
                {
                    ls.Add(tempI[0], 1);
                }
                else
                {
                    ls[tempI[1]]++;
                }
            }
        }
    }
}
