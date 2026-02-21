using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace culc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            double c = double.Parse(Console.ReadLine());
            List<double> xs = FindX(a, b, c);
            foreach (double x in xs) Console.WriteLine(x);
        }
        static List<double> FindX(double a, double b, double c)
        {
            try
            {
                double discr = FindDiscr(a, b, c);
                double x1;
                double x2;
                List<double> xs = new List<double>();
                if (discr > 0)
                {
                    x1 = (-b - Math.Sqrt(discr)) / (2 * a);
                    x2 = (-b + Math.Sqrt(discr)) / (2 * a);
                    xs.Add(x1);
                    xs.Add(x2);
                }
                else if (discr == 0)
                {
                    x1 = -b / (2 * a);
                    xs.Add(x1);
                }
                else
                {
                    Console.WriteLine("Корней нет");
                }
                return xs;
            }
            catch
            {
                return new List<double>();
            }

        }
        static double FindDiscr(double a, double b, double c)
        {
            return Math.Pow(b, 2) - 4 * a * c;
        }
    }
}
