using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valtozok
{
    class Program
    {
        static void Main(string[] args)
        {
            valtozokegyesitese();
            Console.ReadKey();
        }
        static void valtozokegyesitese()
        {
            Console.Write("Család Név:");
            string fn = Console.ReadLine(); //fn valtozo neve = benne tarolom a csaladi nevet
            Console.Write("Keresztnév: ");
            string kn = Console.ReadLine();
            Console.WriteLine(("{0}, {1}"), fn, kn);
            Console.WriteLine();

            //--- eredmény: Sallai, Martin ---//
        }
    }
}
