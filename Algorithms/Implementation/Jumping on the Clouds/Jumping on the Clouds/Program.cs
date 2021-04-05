using System;

namespace Jumping_on_the_Clouds
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            string[] tmp = Console.ReadLine().Split(' ');
            int k = 0, pos = 1;
            while(pos != tmp.Length)
            {
                if(pos + 2 <= tmp.Length && tmp[pos + 1] == "0")
                    pos += 2;
                else if(pos + 1 <= tmp.Length && tmp[pos] == "0")
                    pos += 1;
                k++;
            }
            Console.WriteLine(k);
            Console.ReadKey();
        }
    }
}