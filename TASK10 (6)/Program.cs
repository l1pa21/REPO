using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите количество первых простых чисел n:");
        int n = int.Parse(Console.ReadLine());

        int found = 0;
        int current = 2;

        Console.WriteLine($"Первые {n} простых чисел:");
        while (found < n)
        {
            if (IsPrime(current))
            {
                Console.Write(current + " ");
                found++;
            }
            current++;
        }
    }

    static bool IsPrime(int num)
    {
        if (num < 2) return false;
        for (int i = 2; i * i <= num; i++)
        {
            if (num % i == 0) return false;
        }
        return true;
    }
}
