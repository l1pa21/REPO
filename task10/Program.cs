using System;

class Program
{
    static void Main()
    {
        int m, n;

        Console.Write("Введите m: ");
        while (!int.TryParse(Console.ReadLine(), out m))
        {
            Console.Write("Ошибка! Введите ЧИСЛО для m: ");
        }

        Console.Write("Введите n: ");
        while (!int.TryParse(Console.ReadLine(), out n))
        {
            Console.Write("Ошибка! Введите ЧИСЛО для n: ");
        }

        long result = 1;

        for (int i = m; i <= n; i++)
        {
            result *= i;
        }

        Console.WriteLine($"Произведение = {result}");
        Console.ReadLine();
    }
}
