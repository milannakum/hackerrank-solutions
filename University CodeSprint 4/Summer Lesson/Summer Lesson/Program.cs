using System;

namespace Summer_Lesson
{
    class Program
    {
        static int[] howManyStudents(int m, int[] c)
        {
            int[] res = new int[m];
            for (int i = 0; i < c.Length; i++)
                res[c[i]]++;
            return res;
        }

        static void Main(String[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            string[] c_temp = Console.ReadLine().Split(' ');
            Console.WriteLine(string.Join(" ", howManyStudents(Convert.ToInt32(tokens_n[1]), Array.ConvertAll(c_temp, int.Parse))));
        }
    }
}