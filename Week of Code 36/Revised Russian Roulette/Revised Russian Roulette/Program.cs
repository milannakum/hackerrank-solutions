using System;

namespace Revised_Russian_Roulette
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.ReadLine();
            string[] doors_temp = Console.ReadLine().Split(' ');
            int[] doors = Array.ConvertAll(doors_temp, Int32.Parse);
            int count = 0, maxUnlock = 0;
            for (int i = 0; i < doors.Length; i++)
            {
                if (doors[i] == 1)
                {
                    maxUnlock++;
                    count++;
                    if ((i + 1) <= (doors.Length - 1))
                        if (doors[i + 1] == 1)
                        {
                            maxUnlock++;
                            i++;
                        }
                }
            }

            Console.WriteLine(count + " " + maxUnlock);
        }
    }
}