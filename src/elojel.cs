using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ywusm7_210924
{
    class Program
    {
        static void Main(string[] args)
        {
            elojel(); //1.feladat
            switch_gyak(); //2.feladat
            szamosszeg();
            csokkeno();
            csillagok();

            Console.ReadKey();
        }
        static void elojel ()
        { //start

            Console.WriteLine("Előjel vizsgálat -");
            Console.WriteLine("Kérek két számot");

            string be = Console.ReadLine();
            int a = Convert.ToInt32(be);

            int b = int.Parse(Console.ReadLine());

            if (a*b>0)
            {
                Console.WriteLine("Azonos előjel");
            }
            else
            {
                Console.WriteLine("Nem azonos előjel");
            }

        } //end 
        static void switch_gyak()
        { //start

            Console.WriteLine("kis és nagy betű konvertálás");
            Console.WriteLine("Kérek 1 betűt! a-tól b-ig, vagy A-tól B-ig");

            string a = Console.ReadLine();

            switch (a)
            {
                case "a":
                    Console.WriteLine("A");
                    break;

                case "A":
                    Console.WriteLine("a");
                    break;

                //** **//

                case "b":
                    Console.WriteLine("B");
                    break;

                case "B":
                    Console.WriteLine("b");
                    break;

               //** **//

                default:
                    break;
            } //switch end

        } //end
        static void szamosszeg()
        { //start

            Console.WriteLine("Első 20 szám összege (1-20ig)");
            int osszeg = 0;
            for (int i = 1; 1 < 20; i++)
            {
                osszeg = osszeg + 1;
            }
            Console.WriteLine(osszeg);

        } //end+
        static void csokkeno ()
        {
            Console.WriteLine("24-6ig harmassával csökkenő számok");

            for (int i = 24; i <6      ; i++)
            {
                Console.Write(i);
                // ???????w???????? //

            }
        }
        static void csillagok ()
        {
            Console.WriteLine("csillagok nyomtatása");
            Console.WriteLine("Kérek be egy számot");

            int szam = Int32.Parse(Console.ReadLine());
            //
            for (int i = 0; i < darab; i++)
            {

            }


        }
    }
}