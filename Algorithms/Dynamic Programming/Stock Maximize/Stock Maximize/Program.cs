using System;

namespace Stock_Maximize
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < t; i++)
            {
                Console.ReadLine();
                string[] temp = Console.ReadLine().Split(' ');
                int[] arr = Array.ConvertAll(temp, Int32.Parse);
                int[] diff = new int[arr.Length - 1];
                for(int j = 0; j < arr.Length; j++)
                {
                    if(arr[i + 1] > arr[i])
                        diff[j] = arr[i + 1] - arr[i];
                    else
                        diff[j] = 0;
                }
                
            }
        }
    }
}