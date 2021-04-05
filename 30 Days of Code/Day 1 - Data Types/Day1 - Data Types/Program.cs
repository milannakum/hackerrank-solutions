using System;

namespace Day1___Data_Types
{
    class Program
    {
        static int waysToGiveACheck(char[][] board)
        {
            int res = 0;
            int bkrow = 0, bkcol = 0, wKrow = 0, wKcol = 0, wProw = 0, wPcol = 0;
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                {
                    if (board[i][j] == '#') continue;
                    else if (board[i][j] == 'k')
                    {
                        bkcol = j;
                        bkrow = i;
                    }
                    else if (board[i][j] == 'P')
                    {
                        wPcol = j;
                        wProw = i + 1;
                    }
                    else if (board[i][j] == 'K')
                    {
                        wKcol = j;
                        wKrow = i;
                    }
                }


            //For King
            if ((bkcol == wKcol + 1 && bkrow == wKrow) ||
                (bkcol == wKcol - 1 && bkrow == wKrow) ||
                (bkcol == wKcol && bkrow == wKrow + 1) ||
                (bkcol == wKcol && bkrow == wKrow - 1) ||
                (bkcol == wKcol + 1 && bkrow == wKrow + 1) ||
                (bkcol == wKcol + 1 && bkrow == wKrow - 1) ||
                (bkcol == wKcol - 1 && bkrow == wKrow + 1) ||
                (bkcol == wKcol - 1 && bkrow == wKrow - 1))
                res++;

            //For Knight
            if ((bkrow == 6 && bkcol == wPcol + 2) || (bkrow == 6 && bkcol == wPcol - 2) ||
                (bkrow == 5 && bkcol == wPcol + 1) || (bkrow == 5 && bkcol == wPcol - 1))
                res++;

            //For Rook
            for (int i = 0; i < 7; i++)
            {
                if (bkcol == wPcol && bkrow == wProw - i && (wKcol < bkcol))
                    res++;
                if (bkrow == wProw && ((bkcol == wPcol - i && wKrow < bkrow) || (bkcol == wPcol + i && wKrow < bkrow)))
                    res++;
            }


            //For Bishop
            if ()
                res++;

            //For Queen
            if ()
                res++;



            return res;
        }

        static void Main(String[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                char[][] board = new char[8][];
                for (int board_i = 0; board_i < 8; board_i++)
                {
                    string[] board_temp = Console.ReadLine().Split(' ');
                    board[board_i] = Array.ConvertAll(board_temp, Char.Parse);
                }
                int result = waysToGiveACheck(board);
                Console.WriteLine(result);
            }
        }
    }
}