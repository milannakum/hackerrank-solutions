using System;
using System.Collections.Generic;

namespace HackerRank_in_a_String_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                Stack<char> st = new Stack<char>();
                foreach(char ch in s)
                    if(ch == 'h')
                    {
                        st.Push(ch);
                        s = s.Remove(0, s.IndexOf(ch) + 1);
                        break;
                    }
                foreach(char ch in s)
                    if(ch == 'a')
                    {
                        st.Push(ch);
                        s = s.Remove(0, s.IndexOf(ch) + 1);
                        break;
                    }
                foreach(char ch in s)
                    if(ch == 'c')
                    {
                        st.Push(ch);
                        s = s.Remove(0, s.IndexOf(ch) + 1);
                        break;
                    }
                foreach(char ch in s)
                    if(ch == 'k')
                    {
                        st.Push(ch);
                        s = s.Remove(0, s.IndexOf(ch) + 1);
                        break;
                    }
                foreach(char ch in s)
                    if(ch == 'e')
                    {
                        st.Push(ch);
                        s = s.Remove(0, s.IndexOf(ch) + 1);
                        break;
                    }
                foreach(char ch in s)
                    if(ch == 'r')
                    {
                        st.Push(ch);
                        s = s.Remove(0, s.IndexOf(ch) + 1);
                        break;
                    }
                foreach(char ch in s)
                    if(ch == 'r')
                    {
                        st.Push(ch);
                        s = s.Remove(0, s.IndexOf(ch) + 1);
                        break;
                    }
                foreach(char ch in s)
                    if(ch == 'a')
                    {
                        st.Push(ch);
                        s = s.Remove(0, s.IndexOf(ch) + 1);
                        break;
                    }
                foreach(char ch in s)
                    if(ch == 'n')
                    {
                        st.Push(ch);
                        s = s.Remove(0, s.IndexOf(ch) + 1);
                        break;
                    }
                foreach(char ch in s)
                    if(ch == 'k')
                    {
                        st.Push(ch);
                        s = s.Remove(0, s.IndexOf(ch) + 1);
                        break;
                    }
                if(new string(st.ToArray()) == "knarrekcah")
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
            }
            Console.ReadKey();
        }
    }
}