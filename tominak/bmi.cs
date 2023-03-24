using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bmi
{
    class Program
    {
        static void Main(string[] args)
        {
            bmi();
            Console.ReadKey();
        }
        static void bmi()
        {
            Console.Write("Testömeg (kg):");
            string be = Console.ReadLine();
            int kg = Convert.ToInt32(be);
            Console.Write("Magasság (cm):");
            string bee = Console.ReadLine();
            int cm = Convert.ToInt32(bee);
            double m = cm / 10;
            double tti = kg / m * m;
            Console.WriteLine("tti:" + tti);
            Console.ReadKey();
        }
    }
}
