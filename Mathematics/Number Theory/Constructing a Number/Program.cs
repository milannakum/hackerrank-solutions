using System;

namespace Constructing_a_Number
{
    class Program
    {
        public static string swapString(string a, int i, int j)
        {
            char[] b = a.ToCharArray();
            char ch;
            ch = b[i];
            b[i] = b[j];
            b[j] = ch;
            return b.ToString();
        }

        public static string generatePermutation(string str, int start, int end)
        {
            //Prints the permutations    
            if (start == end - 1) return "No";
            else
            {
                for (int i = start; i < end; i++)
                {
                    //Swapping the string by fixing a character    
                    str = swapString(str, start, i);
                    if (Convert.ToInt64(str) % 3 == 0) return "Yes";

                    //Recursively calling function generatePermutation() for rest of the characters     
                    string x = generatePermutation(str, start + 1, end);
                    if (x == "Yes") return x;
                    //Backtracking and swapping the characters again.    
                    str = swapString(str, start, i);
                    if (Convert.ToInt64(str) % 3 == 0) return "Yes";
                }
            }
            return "No";
        }

        // Complete the canConstruct function below.
        static string CanConstruct(long[] a)
        {
            // Return "Yes" or "No" denoting whether you can construct the required number.
            string str = "";
            foreach (long y in a) str += y;
            return generatePermutation(str, 0, str.Length);
        }

        static void Main(string[] args)
        {
            progStart:

            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                long[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt64(aTemp))
                ;
                string result = CanConstruct(a);

                Console.WriteLine(result);
            }

            goto progStart;
        }
    }
}
