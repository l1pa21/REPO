using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Задание 1: Введите натуральное число:");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите цифру k для подсчета в десятичной записи числа:");
        char k = Console.ReadLine()[0];

        string decimalNumber = number.ToString();

        int count = 0;
        foreach (char c in decimalNumber)
        {
            if (c == k) count++;
        }

        Console.WriteLine($"Цифра {k} встречается {count} раз(а) в десятичной записи числа {number}.");
    }
}
