using System;

namespace Flatland_Space_Stations
{
    class Program
    {
        // Complete the flatlandSpaceStations function below.
        static int flatlandSpaceStations(int n, int[] c)
        {
            if (n == c.Length) return 0;

            Array.Sort(c);
            int lastStation = n - 1;
            int max = 0;
            for (int i = 0; i < c.Length; i++)
            {
                int elem = c[i];

                if (i == 0 && elem > 0 && elem > max) max = elem;
                if(i == (c.Length - 1) && elem < lastStation)
                {
                    int tempMax = lastStation - elem;
                    if (tempMax > max) max = tempMax;
                    break;
                }

                int next1 = ((i + 1) < c.Length) ? c[i + 1] : -1;
                if (next1 == -1) break;

                int diff = next1 - elem;
                if ((diff == 2 || diff == 3) && max < 1) max = 1;
                else if (diff > 3)
                {
                    int mid = (int)Math.Floor((decimal)diff / 2);
                    if (mid > max) max = mid;
                }
            }

            return max;
        }

        static void Main(string[] args)
        {
            string[] nm = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nm[0]);
            int m = Convert.ToInt32(nm[1]);

            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp));
            int result = flatlandSpaceStations(n, c);

            Console.WriteLine(result);
        }
    }
}
