using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine() ?? "0");

        double[] a = CreateRandomArray(n);

        Console.WriteLine("Исходный массив:");
        PrintArray(a);

        double[] s = AveragedPartialSumsOfSquares(a);

        Console.WriteLine("Массив s:");
        PrintArray(s);

        Console.WriteLine("Проверка: исходный массив не изменился:");
        PrintArray(a);
    }

    static double[] CreateRandomArray(int n)
    {
        double[] arr = new double[n];
        Random rnd = new Random();
        for (int i = 0; i < n; i++) arr[i] = rnd.NextDouble();
        return arr;
    }

    static double[] AveragedPartialSumsOfSquares(double[] arr)
    {
        double[] s = new double[arr.Length];
        double sumSquares = 0;

        for (int k = 0; k < arr.Length; k++)
        {
            sumSquares += arr[k] * arr[k];
            s[k] = sumSquares / (k + 1);
        }

        return s;
    }

    static void PrintArray(double[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"{arr[i]:F4}");
            if (i < arr.Length - 1) Console.Write(" ");
        }
        Console.WriteLine();
    }
}
