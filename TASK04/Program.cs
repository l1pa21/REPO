using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите значение x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        double y = 1.0 / (x * x + 1.0 / (x * x + 1.0 / (x * x + 1.0)));

        Console.WriteLine($"y = {y}");
    }
}
//:)