using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_1
{
    class Program
    {
        static void Main(string[] args)
        {
s
            feladat2();

            Console.ReadKey();
            //------------------------------------------


        }

        static void feladat2()
        {
            Console.WriteLine("kérem az oldalakat");
            int a = 10, b, c;
            string be = Console.ReadLine();
            a = Convert.ToInt32(be);
            be = Console.ReadLine();
            b = Convert.ToInt32(be);
            be = Console.ReadLine();
            c = Convert.ToInt32(be);
            if (/*feltétel*/a + b > c && a + c > b && c + b > a)
            {
                double s;
                s = (a + b + c) / 2.0;
                double t;
                t = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
                Console.Write("Terület:");
                Console.WriteLine(t);
            }
            else
            {
                Console.WriteLine("Rossz adat");
            }
        }
    }
}

#spam:

s=tii/b-a tii>> b&&a
double s
a + b
int 32
int 24
if
    }
a + b + c
    {
    return;
1X 44
58 25
{
 Math.Sqrt

}

    
