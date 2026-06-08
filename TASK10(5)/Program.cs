using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите натуральное число:");
        string number = Console.ReadLine();
        char[] digits = number.ToCharArray();
        int len = digits.Length;

        for (int i = 0; i < len / 2; i++)
        {
            int j = len - 1 - i; 

            char temp = digits[i];
            digits[i] = digits[j];
            digits[j] = temp;

            // Выводим промежуточный результат :)) 
            Console.WriteLine($"После обмена цифр {i + 1} и {j + 1}: {new string(digits)}");
        }

        Console.WriteLine("Итоговый результат: " + new string(digits));
    }
}
