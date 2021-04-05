using System;

namespace Acid_Naming
{
    class Program
    {
        static string acidNaming(string x)
        {
            if (x[0] == 'h' && x[1] == 'y' && x[2] == 'd' && x[3] == 'r' && x[4] == 'o' && x[x.Length - 2] == 'i' && x[x.Length - 1] == 'c')
                return "non-metal acid";
            else if (x[x.Length - 2] == 'i' && x[x.Length - 1] == 'c')
                return "polyatomic acid";
            else
                return "not an acid";
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < n; a0++)
            {
                string acid_name = Console.ReadLine();
                string result = acidNaming(acid_name);
                Console.WriteLine(result);
            }
        }
    }
}