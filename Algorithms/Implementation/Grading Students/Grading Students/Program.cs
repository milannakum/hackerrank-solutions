using System;
using System.Collections.Generic;
using System.Linq;

namespace Grading_Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] grades = new int[n];
            for(int grades_i = 0; grades_i < n; grades_i++)
            {
                grades[grades_i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] result = solve(grades);
            Console.WriteLine(String.Join("\n", result));
            Console.ReadKey();
        }

        static int[] solve(int[] grades)
        {
            for(int i = 0; i < grades.Length; i++)
                if(grades[i] % 5 > 2 && grades[i] > 37)
                    grades[i] = grades[i] + 5 - (grades[i] % 5);
                else
                    grades[i] = grades[i];

            return grades;
        }
    }
}
