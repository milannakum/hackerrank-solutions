using System;

namespace Left_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int d = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            int[] result = leftRotation(a, d, n);
            Console.WriteLine(String.Join(" ", result));
            Console.ReadKey();
        }

        private static int[] leftRotation(int[] a, int d, int n)
        {
            int[] res = new int[n];
            if(d > n)
                d = d % n;
            if(d == n)
                Array.Copy(a, res, n);
            else
                for(int i = 0; i < n; i++)
                    if(i + d < n)
                        res[i] = a[i + d];
                    else
                        res[i] = a[i + d - n];
            
            return res;
        }
    }
}
