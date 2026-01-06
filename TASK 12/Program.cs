using System;

class Program
{
    static void Main()
    {
        int m = ReadIntInRange("Введите m (5..20): ", 5, 20);
        int n = ReadIntInRange("Введите n (5..20): ", 5, 20);

        int[,] a = CreateMatrix(m, n);

        Console.WriteLine("\nМатрица:");
        PrintMatrix(a);

        // (a) поиск заданного числа
        Console.Write("\nВведите число для поиска (0..99): ");
        int x = int.Parse(Console.ReadLine() ?? "0");

        var pos = FindFirst(a, x);
        if (pos.found)
            Console.WriteLine($"Элемент {x} найден: строка = {pos.row}, столбец = {pos.col}");
        else
            Console.WriteLine($"Элемент {x} не найден.");

        // (б) максимум в каждой строке
        int[] rowMax = RowMaxValues(a);
        Console.WriteLine("\nМаксимумы по строкам:");
        for (int i = 0; i < rowMax.Length; i++)
            Console.WriteLine($"Строка {i}: max = {rowMax[i]}");
    }


    static int ReadIntInRange(string prompt, int min, int max)
    {
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out int value) && value >= min && value <= max)
                return value;

            Console.WriteLine($"Ошибка ввода. Введите целое число от {min} до {max}.");
        }
    }

    static int[,] CreateMatrix(int m, int n)
    {
        int[,] matrix = new int[m, n];
        Random rnd = new Random();

        for (int i = 0; i < m; i++)
            for (int j = 0; j < n; j++)
                matrix[i, j] = rnd.Next(0, 100); // 0..99

        return matrix;
    }

    static void PrintMatrix(int[,] matrix)
    {
        int m = matrix.GetLength(0);
        int n = matrix.GetLength(1);

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
                Console.Write($"{matrix[i, j],4}"); // ширина 4 символа
            Console.WriteLine();
        }
    }


    // (a) Метод: есть ли в массиве элемент, равный x.
    // Возвращает found/row/col (ничего не печатает).
    static (bool found, int row, int col) FindFirst(int[,] matrix, int x)
    {
        int m = matrix.GetLength(0);
        int n = matrix.GetLength(1);

        for (int i = 0; i < m; i++)
            for (int j = 0; j < n; j++)
                if (matrix[i, j] == x)
                    return (true, i, j);

        return (false, -1, -1);
    }

    // (б) Метод: максимальный элемент в каждой строке.
    // Возвращает массив максимумов (ничего не печатает).
    static int[] RowMaxValues(int[,] matrix)
    {
        int m = matrix.GetLength(0);
        int n = matrix.GetLength(1);

        int[] maxs = new int[m];

        for (int i = 0; i < m; i++)
        {
            int max = matrix[i, 0];
            for (int j = 1; j < n; j++)
                if (matrix[i, j] > max)
                    max = matrix[i, j];

            maxs[i] = max;
        }

        return maxs;
    }
}
//