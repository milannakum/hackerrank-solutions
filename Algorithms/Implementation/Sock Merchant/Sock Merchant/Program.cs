using System;

namespace Sock_Merchant
{
    class Program
    {
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] ar_temp = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
            int result = sockMerchant(n, ar);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        static int sockMerchant(int n, int[] ar)
        {
            int res = 0;
            Array.Sort(ar);
            int temp = 0;
            for(int i = 0; i < n; i++)
            {
                if(temp == 0)
                {
                    temp = ar[i];
                }
                else
                {
                    if(ar[i] == temp)
                    {
                        res++;
                        temp = 0;
                    }
                    else
                        temp = ar[i];
                }
            }

            return res;
        }
    }
}
