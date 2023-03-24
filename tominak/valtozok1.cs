using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tominak2
{
    class Program
    {
        static void Main(string[] args)
        {
            feladat1();
            Console.ReadKey();
        }
        static void feladat1()
        {
            Console.WriteLine("Szia add meg a neved");

            //bekérek
            Console.ReadLine();
            string name = Console.ReadLine();

                            //hozzá teszek vmit + name = ebbe van be töltve az adat
            Console.WriteLine("örülök neked" + name);
            //kiirom

            Console.ReadKey();
            //------------------------------------------
        }
    }
}
