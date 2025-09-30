using System;

class Program
{
    static void Main()
    {
        // Bвод данных
        Console.Write("Введите длину стороны a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Введите длину стороны b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Введите угол между ними в градусах: ");
        double angleDegrees = double.Parse(Console.ReadLine());

        // Переводим угол в радианы
        double angleRadians = angleDegrees * Math.PI / 180.0;

        // Вычисляем площадь
        double area = 0.5 * a * b * Math.Sin(angleRadians);

        // Находим третью сторону по теореме косинусов
        double c = Math.Sqrt(a * a + b * b - 2 * a * b * Math.Cos(angleRadians));

        // Вычисляем периметр
        double perimeter = a + b + c;

        // Выводим результат
        Console.WriteLine($"Площадь треугольника: {area:F2}");
        Console.WriteLine($"Периметр треугольника: {perimeter:F2}");
    }
}