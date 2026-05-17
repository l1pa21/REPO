using System;

class Program
{
    // Метод определяет принадлежит ли точка (x, y) области :D
    static bool IsInsideArea(double x, double y)
    {
        return y >= -2 && y <= 1.5;
    }

    static void Main()
    {
        Console.Write("Введите x: ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("Введите y: ");
        double y = double.Parse(Console.ReadLine());

        bool inside = IsInsideArea(x, y);

        if (inside)
            Console.WriteLine("Точка принадлежит области.");
        else
            Console.WriteLine("Точка не принадлежит области.");
    }
}