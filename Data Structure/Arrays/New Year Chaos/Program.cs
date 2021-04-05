using System;

namespace New_Year_Chaos
{
    class Program
    {
        // Complete the minimumBribes function below.
        static void minimumBribes(int[] q)
        {
            //bool tooChaotic = false;
            //int bribes = 0;
            //for (int i = 0; i < q.Length -1 ; i++)
            //{
            //    if (i + 1 == q.Length) continue;

            //    int elem = q[i];
            //    int nextElem1 = q.Length <= (i + 1) ? 0 : q[i + 1];
            //    int nextElem2 = q.Length <= (i + 2) ? 0 : q[i + 2];
            //    int shifts = elem - (i + 1);

            //    if (shifts > 2)
            //    {
            //        tooChaotic = true;
            //        break;
            //    }
            //    if (shifts > 0 && (i < (q.Length -2))) bribes += shifts;

            //    /*else if(shifts < 0 && (i + 1 <= q.Length))
            //    {
            //        for (int j = i + 1; j < q.Length; j++)
            //        {
            //            int nextElem = q[j];
            //            if (nextElem < elem) bribes++;
            //        }
            //    }*/
            //    //if (nextElem1 != 0 && nextElem1 < elem && (nextElem2 == 0 || nextElem2 < nextElem1)) bribes++;
            //    //if (nextElem1 != 0 && nextElem1 < elem && (nextElem2 < nextElem1)) bribes++;
            //    if (shifts < 2 && nextElem1 != 0 && nextElem1 < elem && (nextElem2 != 0 && nextElem2 < nextElem1)) bribes++;
            //    else if (shifts == 0 && nextElem1 != 0 && nextElem1 < elem) bribes++;
            //    else if (nextElem1 != 0 && nextElem1 < elem && nextElem2 == 0 ) bribes++;
            //}
            //Console.WriteLine(tooChaotic ? "Too chaotic" : bribes.ToString());
            int totalBribes = 0;
            bool tooChaotic = false;

            int expectedFirst = 1;
            int expectedSecond = 2;
            int expectedThird = 3;

            for (uint i = 0; i < q.Length; ++i)
            {
                if (q[i] == expectedFirst)
                {
                    expectedFirst = expectedSecond;
                    expectedSecond = expectedThird;
                    ++expectedThird;
                }
                else if (q[i] == expectedSecond)
                {
                    ++totalBribes;
                    expectedSecond = expectedThird;
                    ++expectedThird;
                }
                else if (q[i] == expectedThird)
                {
                    totalBribes += 2;
                    ++expectedThird;
                }
                else
                {
                    tooChaotic = true;
                    break;
                }
            }

            Console.WriteLine(tooChaotic ? "Too chaotic" : totalBribes.ToString());
        }

        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int[] q = Array.ConvertAll(Console.ReadLine().Split(' '), qTemp => Convert.ToInt32(qTemp));
                minimumBribes(q);
            }
        }
    }
}
