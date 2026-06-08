using System;

class Program
{
    static void Main()
    {
        double a;
        Console.WriteLine("a:");
        a = double.Parse(Console.ReadLine());

        int n = 1;

        while (true)
        {
            double x = 1 + 1 / Math.Sqrt(n);
            if (x >= a)
            {
                Console.WriteLine("1 + 1/sqrt(" + n + ")");
            }
            else
            {
                break;
            }
            n++;
        }
    }
}
