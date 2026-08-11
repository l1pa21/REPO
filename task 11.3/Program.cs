using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine() ?? "0");

        double[] a = CreateRandomArray(n);

        Console.WriteLine("Массив:");
        PrintArray(a);

        double result = SumProductsWithIndex(a);
        Console.WriteLine($"Сумма a[i] * i = {result:F4}");
    }

    static double[] CreateRandomArray(int n)
    {
        double[] arr = new double[n];
        Random rnd = new Random();
        for (int i = 0; i < n; i++) arr[i] = rnd.NextDouble();
        return arr;
    }

    static double SumProductsWithIndex(double[] arr)
    {
        double sum = 0;
        for (int i = 0; i < arr.Length; i++)
            sum += arr[i] * i;
        return sum;
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

