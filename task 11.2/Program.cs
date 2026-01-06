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

        DivideBySum(a);

        Console.WriteLine("После деления на сумму:");
        PrintArray(a);
    }

    static double[] CreateRandomArray(int n)
    {
        double[] arr = new double[n];
        Random rnd = new Random();
        for (int i = 0; i < n; i++) arr[i] = rnd.NextDouble();
        return arr;
    }

    static void DivideBySum(double[] arr)
    {
        double sum = 0;
        for (int i = 0; i < arr.Length; i++) sum += arr[i];

        if (sum == 0) return;

        for (int i = 0; i < arr.Length; i++) arr[i] /= sum;
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
