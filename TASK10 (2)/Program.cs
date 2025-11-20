using System;

class Program
{
    static void Main()
    {
        int n;
        Console.WriteLine("Введите кол-во единиц:");
        n = int.Parse(Console.ReadLine());

        double max = 0;
        int imax = 1;

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Население:");
            double p = double.Parse(Console.ReadLine());

            Console.WriteLine("Нас. пункты:");
            int k = int.Parse(Console.ReadLine());

            double sr = p / k;

            if (sr > max)
            {
                max = sr;
                imax = i;
            }
        }

        Console.WriteLine("Ответ: " + imax);
    }
}
