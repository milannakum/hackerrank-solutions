using System;
using System.Collections.Generic;
using System.Linq;

namespace Migratory_Birds
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] ar_temp = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
            int result = migratoryBirds(n, ar);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        static int migratoryBirds(int n, int[] ar)
        {
            int b1 = 0, b2 = 0, b3 = 0, b4 = 0, b5 = 0;
            foreach(int i in ar)
            {
                switch(i)
                {
                    case 1:
                        b1++;
                        break;
                    case 2:
                        b2++;
                        break;
                    case 3:
                        b3++;
                        break;
                    case 4:
                        b4++;
                        break;
                    case 5:
                        b5++;
                        break;
                }
            }
            int[] resA = new int[5] { b1, b2, b3, b4, b5 };

            return Array.IndexOf(resA, resA.Max()) + 1;
        }
    }
}
