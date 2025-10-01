using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите k (1 ≤ k ≤ 150): ");
        int k = int.Parse(Console.ReadLine());

        if (k < 1 || k > 150)
        {
            Console.WriteLine("Ошибка: k должно быть в пределах 1 ≤ k ≤ 150");
        }
        else
        {
            int number = 100 + k;
            Console.WriteLine($"Число, которое стоит на {k}-м месте последовательности: {number}");
        }
    }
}
