using System;

namespace Train_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(berthType(Convert.ToInt32(Console.ReadLine())));
        }

        static string berthType(int n)
        {
            if (n % 8 == 1 || n % 8 == 4)
                return "LB";
            if (n % 8 == 2 || n % 8 == 5)
                return "MB";
            if (n % 8 == 3 || n % 8 == 6)
                return "UB";
            if (n % 8 == 7)
                return "SLB";
            else
                return "SUB";
        }
    }
}
