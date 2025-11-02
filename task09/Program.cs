using System;

class Program
{
    static double CalculateF(double x)
    {
        if (Math.Abs(x) > 1)
        {
            return 1;
        }
        else if (x > 0 && Math.Abs(x) <= 1)
        {
            return Math.Abs(x);
        }
        else // x = 0
        {
            return 2;
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Введите x: ");
        double x = double.Parse(Console.ReadLine());
        double result = CalculateF(x);
        Console.WriteLine($"f({x}) = {result}");
    }
}
