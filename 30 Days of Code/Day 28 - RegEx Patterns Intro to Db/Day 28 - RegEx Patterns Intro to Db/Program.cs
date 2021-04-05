using System;
using System.Collections.Generic;

namespace Day_28___RegEx_Patterns_Intro_to_Db
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            List<string> email = new List<string>();
            List<string> name = new List<string>();
            for (int a0 = 0; a0 < N; a0++)
            {
                string[] tokens_firstName = Console.ReadLine().Split(' ');
                string firstName = tokens_firstName[0];
                string emailID = tokens_firstName[1];
                if (emailID.Contains("@gmail.com") && emailID[emailID.Length - 10] == '@')
                {
                    email.Add(emailID);
                    name.Add(firstName);
                }
            }
            name.Sort();
            foreach (string s in name)
                Console.WriteLine(s);
        }
    }
}