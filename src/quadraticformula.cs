using System;

namespace másofokú_éles
{
    class Program
    {
        static void Main(string[] args)
        {
            masodfoko();
            Console.ReadKey();

        }
        static void masodfoko()
        {
            double a;
            double b;
            double c;
            double d;
            double x1;
            double x2;

            Console.WriteLine("Quadratic equation");
            Console.WriteLine("Input 'a' ");
            a = Convert.ToDouble(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine(" Not Do-able");
            }
            else
            {
                Console.WriteLine("Input 'b' ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Input 'c' értékét");
                c = Convert.ToDouble(Console.ReadLine());

                d = b * b - 4 * a * c;

                if (d < 0)
                {
                    Console.WriteLine("Not Do-able");
                }
                else
                {
                    x1 = -b + 4 * a * c;

                    x2 = -b + 4 * a * c;



                }

            }
        }
    }
}