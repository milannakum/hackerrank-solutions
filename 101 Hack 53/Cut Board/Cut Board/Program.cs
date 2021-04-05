using System;

namespace Cut_Board
{
    class Program
    {
        static void fillBoard(int n, int m, int x, int y)
        {

        }


        static void Main(string[] args)
        {
            string[] nmxy = Console.ReadLine().Split(' ');
            fillBoard(
                Convert.ToInt32(nmxy[0]),
                Convert.ToInt32(nmxy[1]),
                Convert.ToInt32(nmxy[2]),
                Convert.ToInt32(nmxy[3]));
        }
    }
}