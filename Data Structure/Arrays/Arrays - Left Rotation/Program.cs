using System;

namespace Arrays___Left_Rotation
{
    class Program
    {
        // Complete the rotLeft function below.
        static int[] rotLeft(int[] a, int d)
        {
            if (d == a.Length) return a;

            int count = 0;
            int[] resultArr = new int[a.Length];
            for (int i = d; i < a.Length; i++)
            {
                resultArr[count] = a[i];
                count++;
            }
            for (int i = 0; i < d; i++)
            {
                resultArr[count] = a[i];
                count++;
            }

            return resultArr;
        }

        static void Main(string[] args)
        {
            string[] nd = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nd[0]);

            int d = Convert.ToInt32(nd[1]);

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
            int[] result = rotLeft(a, d);

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
