using System;

namespace Winning_Lottery_Ticket
{
    class Program
    {
        static int winningLotteryTicket(string[] tickets)
        {
            int res = 0;
            for (int i = 0; i < tickets.Length; i++)
            {

            }


            return res;
        }



        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] tickets = new string[n];
            for (int tickets_i = 0; tickets_i < n; tickets_i++)
            {
                tickets[tickets_i] = Console.ReadLine();
            }
            int result = winningLotteryTicket(tickets);
            Console.WriteLine(result);
        }
    }
}