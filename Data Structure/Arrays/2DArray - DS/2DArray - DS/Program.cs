using System;
using System.Linq;

namespace _2DArray___DS
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[6][];
            for(int arr_i = 0; arr_i < 6; arr_i++)
            {
                string[] arr_temp = Console.ReadLine().Split(' ');
                arr[arr_i] = Array.ConvertAll(arr_temp, Int32.Parse);
            }
            int[] calcLs = new int[16];
            int[,] mainAr = new int[16, 7];
            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    mainAr[i * 4 + j, 0] = arr[i][j];
                    mainAr[i * 4 + j, 1] = arr[i][j + 1];
                    mainAr[i * 4 + j, 2] = arr[i][j + 2];
                    mainAr[i * 4 + j, 3] = arr[i + 1][j + 1];
                    mainAr[i * 4 + j, 4] = arr[i + 2][j];
                    mainAr[i * 4 + j, 5] = arr[i + 2][j + 1];
                    mainAr[i * 4 + j, 6] = arr[i + 2][j + 2];
                    int temp = 0;
                    for(int k = 0; k < 7; k++)
                    {
                        temp += mainAr[i * 4 + j, k];
                    }
                    calcLs[i * 4 + j] = temp;
                }
            }
            Console.WriteLine(calcLs.Max());
            Console.ReadKey();
        }
    }
}
