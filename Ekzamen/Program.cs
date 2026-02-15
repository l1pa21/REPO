using System;

class Program
{
    // здесь я сделал ппрвоерку
    static bool IsChastokol(long n)
    {
        for (long baseNum = 2; baseNum * baseNum <= n; baseNum++)
        {
            long sum = 1;
            long power = 1;

            // зедсь стрим число вида 111..
            while (sum < n)
            {
                power *= baseNum;
                sum += power;

                if (sum == n)
                    return true;
            }
        }

        return false;
    }

    static void Main()
    {
        const int LIMIT = 100000;
        long totalSum = 0;

        for (int i = 1; i < LIMIT; i++)
        {
            if (i == 1 || IsChastokol(i))
                totalSum += i;
        }

        Console.WriteLine(totalSum);
    }
}
// Александр Ильич, напишите пожалуйста, если требуется чтобы в консоли требовалось вводить значение предела. :)
