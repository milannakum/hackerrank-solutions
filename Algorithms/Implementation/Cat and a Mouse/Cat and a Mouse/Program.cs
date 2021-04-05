using System;

namespace Cat_and_a_Mouse
{
    class Program
    {
        static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < q; i++)
            {
                string[] tokens_x = Console.ReadLine().Split(' ');
                int x = Convert.ToInt32(tokens_x[0]);
                int y = Convert.ToInt32(tokens_x[1]);
                int z = Convert.ToInt32(tokens_x[2]);

                int diffX = Math.Abs(x - z);
                int diffY = Math.Abs(y - z);

                if(diffY == diffX)
                    Console.WriteLine("Mouse C");
                else if(diffX > diffY)
                    Console.WriteLine("Cat B");
                else if(diffY > diffX)
                    Console.WriteLine("Cat A");
            }

            Console.ReadKey();
        }
    }
}
