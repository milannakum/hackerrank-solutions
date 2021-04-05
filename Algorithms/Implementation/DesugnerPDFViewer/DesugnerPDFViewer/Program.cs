using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesugnerPDFViewer
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] h_temp = Console.ReadLine().Split(' ');
            int[] h = Array.ConvertAll(h_temp, Int32.Parse);
            h_temp = null;
            string word = Console.ReadLine();
            char[] ch = word.ToCharArray();
            word = null;
            int[] iarray = new int[ch.Count()];
            int[] m = new int[ch.Count()];
            for (int i = 0; i < ch.Count() - 1; i++)
            {
                iarray[i] = Convert.ToInt32(ch[i]) - 97;
                m[i] = h[iarray[i]];
            }
            iarray = null;
            h = null;
            Console.WriteLine(m.Max() * ch.Count());
            ch = null;
            Console.ReadKey();
        }
    }
}
