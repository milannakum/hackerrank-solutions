using System;

namespace Points_On_a_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            startProg:

            int n = Convert.ToInt32(Console.ReadLine());

            bool isHorizontalEqual = true;
            bool isVerticalEqual = true;

            int prevX = 0;
            int prevY = 0;

            for (int nItr = 0; nItr < n; nItr++)
            {
                string[] xy = Console.ReadLine().Split(' ');

                int x = Convert.ToInt32(xy[0]);
                int y = Convert.ToInt32(xy[1]);

                if(nItr > 0)
                {
                    if (x != prevX) isHorizontalEqual = false;
                    if (y != prevY) isVerticalEqual = false;
                }

                prevX = x;
                prevY = y;
            }

            bool isValid = (isHorizontalEqual || isVerticalEqual);
            Console.WriteLine(isValid ? "YES" : "NO");

            goto startProg;
        }
    }
}
