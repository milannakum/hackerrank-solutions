using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pangrams
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            if ((s.Contains('A') || s.Contains('a')) &&
                (s.Contains('B') || s.Contains('b')) &&
                (s.Contains('C') || s.Contains('c')) &&
                (s.Contains('D') || s.Contains('d')) &&
                (s.Contains('E') || s.Contains('e')) &&
                (s.Contains('F') || s.Contains('f')) &&
                (s.Contains('G') || s.Contains('g')) &&
                (s.Contains('H') || s.Contains('h')) &&
                (s.Contains('I') || s.Contains('i')) &&
                (s.Contains('J') || s.Contains('j')) &&
                (s.Contains('K') || s.Contains('k')) &&
                (s.Contains('L') || s.Contains('l')) &&
                (s.Contains('M') || s.Contains('m')) &&
                (s.Contains('N') || s.Contains('n')) &&
                (s.Contains('O') || s.Contains('o')) &&
                (s.Contains('P') || s.Contains('p')) &&
                (s.Contains('Q') || s.Contains('q')) &&
                (s.Contains('R') || s.Contains('r')) &&
                (s.Contains('S') || s.Contains('s')) &&
                (s.Contains('T') || s.Contains('t')) &&
                (s.Contains('U') || s.Contains('u')) &&
                (s.Contains('V') || s.Contains('v')) &&
                (s.Contains('W') || s.Contains('w')) &&
                (s.Contains('X') || s.Contains('x')) &&
                (s.Contains('Y') || s.Contains('y')) &&
                (s.Contains('Z') || s.Contains('z')))
                Console.WriteLine("pangram");
            else
                Console.WriteLine("not pangram");

            Console.ReadKey();
        }
    }
}
