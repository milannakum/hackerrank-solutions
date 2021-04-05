using System;
using System.Collections.Generic;
using System.Linq;

namespace Maximum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] sAr = new string[n];
            List<int> st = new List<int>();
            int curMax = 0;
            for(int i = 0; i < n; i++)
            {
                sAr[i] = Console.ReadLine();
                if(sAr[i][0] == '1')
                {
                    string[] tempS = sAr[i].Split(' ');
                    int temp = Convert.ToInt32(tempS[1]);
                    st.Add(temp);
                    if(temp > curMax)
                        curMax = temp;
                }
                else if(sAr[i][0] == '2' && st.Count > 0)
                {
                    if(st[st.Count - 1] == curMax)
                    {
                        st.RemoveAt(st.Count - 1);
                        if(st.Count > 0)
                            curMax = st.Max();
                        else
                            curMax = 0;
                    }
                    else
                        st.RemoveAt(st.Count - 1);
                }
                else if(sAr[i][0] == '3' && st.Count > 0)
                    Console.WriteLine(curMax);
            }
            Console.ReadKey();
        }
    }
}