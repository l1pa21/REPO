using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine() ?? "0");

        double[] a = new double[n];
        Random rnd = new Random();

        for (int i = 0; i < n; i++)
            a[i] = rnd.NextDouble();   // [0;1)

        PrintArray(a);
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

