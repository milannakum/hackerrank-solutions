using System;
using System.Collections.Generic;
using System.IO;

namespace Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetIn(new StreamReader(Console.OpenStandardInput(8192)));
            int t = Convert.ToInt32(Console.ReadLine());
            for(int a0 = 0; a0 < t; a0++)
            {
                string s = Console.ReadLine();
                string result = isBalanced(s);
                Console.WriteLine(a0 + 1 + ". " + result);
            }
            Console.ReadKey();
        }

        static string isBalanced(string s)
        {
            char[] chAr = s.ToCharArray();
            Stack<char> st = new Stack<char>();
            char x = ' ';
            foreach(char ch in chAr)
            {
                if(st.Count > 0)
                    x = st.Peek();
                st.Push(ch);
                if(st.Count > 1 && ((x == '(' && st.Peek() == ')') || (x == '{' && st.Peek() == '}') ||
                    (x == '[' && st.Peek() == ']')))
                {
                    st.Pop();
                    st.Pop();
                }
            }
            return st.Count > 0 ? "NO" : "YES";
        }
    }
}