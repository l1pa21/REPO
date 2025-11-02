class Program
{
    static bool CheckCondition(int t, int p)
    {
        return (t < 20) ^ (p < 20); 
    }

    static void Main()
    {
        Console.Write("Введите t: ");
        int t = int.Parse(Console.ReadLine());

        Console.Write("Введите p: ");
        int p = int.Parse(Console.ReadLine());

        bool result = CheckCondition(t, p);

        Console.WriteLine(); 

        if (t < 20 && p < 20)
        {
            Console.WriteLine("Оба числа меньше 20.");
        }
        else if (t >= 20 && p >= 20)
        {
            Console.WriteLine("Оба числа равны или больше 20.");
        }
        else if (result)
        {
            Console.WriteLine("Только одно из чисел меньше 20.");
        }

        Console.WriteLine("\nРезультат логического выражения: " + result);
    }
}
