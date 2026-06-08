using System;

namespace Task05
{
    internal class Program
    {
        static double CalcPart(double a, double b, double c)
        {
            return (Math.Sin(a) - Math.Cos(b)) / Math.Sqrt(c);
        }

        static void Main()
        {
            double x = CalcPart(2, 3, 5) + CalcPart(3, 4, 7) + CalcPart(5, 6, 11);
            Console.WriteLine($"x = {x:F3}");
        }
    }
}
