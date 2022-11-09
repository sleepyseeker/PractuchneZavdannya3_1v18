using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApp1
{

    class Program
    {
        public static double f(double x, double rad1, double rad2)
        {
            if (x <= -2)
            {
                return -(x + 2);
            }
            else if (x > -2 && x < 0)
            {
                return Math.Sqrt(rad1 * rad1 - (-1 - x) * (-1 - x));
            }
            else if (x == 0)
            {
                return 0;
            }
            else if (x > 0 && x < 4)
            {
                return -Math.Sqrt(rad2 * rad2 - (2 - x) * (2 - x));
            }
            else if (x >= 4 && x < 6)
            {

                return -0.5 * (x - 4);
            }
            else
                return -1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введ1ть рад1ус R1");
            double rad1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введ1ть рад1ус R2");
            double rad2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введ1ть л1ву границю x1");
            double x1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введ1ть праву границю x2");
            double x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введ1ть dx");
            double dx = double.Parse(Console.ReadLine());

            Console.WriteLine("x | \t f(x)");
            for (double i = x1; i <= x2; i += dx)
            {
                Console.WriteLine("{0:0.###} | \t {1:0.###}", i, f(i, rad1, rad2));
            }

            Console.ReadKey();
        }
    }
}