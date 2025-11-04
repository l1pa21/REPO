using System;

class Program
{
    static void DecodePosition(string pos, out int x, out int y)
    {
        x = pos[0] - 'a' + 1;
        y = pos[1] - '0';
    }

    static void Main()
    {
        Console.Write("Введите позицию ферзя (например, d5): ");
        string queenPos = Console.ReadLine()!.ToLower();

        Console.Write("Введите позицию ладьи (например, h5): ");
        string rookPos = Console.ReadLine()!.ToLower();

        DecodePosition(queenPos, out int qx, out int qy);
        DecodePosition(rookPos, out int rx, out int ry);

        if (queenPos.Length != 2 || rookPos.Length != 2 ||
            qx < 1 || qx > 8 || qy < 1 || qy > 8 ||
            rx < 1 || rx > 8 || ry < 1 || ry > 8)
        {
            Console.WriteLine("Некорректные координаты!");
            return;
        }

        if (qx == rx && qy == ry)
        {
            Console.WriteLine("Фигуры не могут стоять на одной клетке!");
            return;
        }

        bool queenHits = (qx == rx) || (qy == ry) || (Math.Abs(qx - rx) == Math.Abs(qy - ry));
        bool rookHits = (qx == rx) || (qy == ry);

        Console.WriteLine();
        Console.WriteLine($"Ферзь: {queenPos}");
        Console.WriteLine($"Ладья: {rookPos}");

        if (queenHits && rookHits)
            Console.WriteLine("Обе фигуры угрожают друг другу!");
        else if (queenHits)
            Console.WriteLine("Ферзь бьёт ладью!");
        else if (rookHits)
            Console.WriteLine("Ладья бьёт ферзя!");
        else
            Console.WriteLine("Фигуры не угрожают друг другу.");
    }
}
