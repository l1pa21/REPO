using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string a = "Александр Блок";
            Console.WriteLine(a);
            Console.ForegroundColor = ConsoleColor.Blue;
            string b = "Чудесно всё, что узнаю?..";
            Console.WriteLine(b);
            Console.ForegroundColor = ConsoleColor.Red;
            string c = "Чудесно всё, что узнаю? ,\nПостыдно всё, что совершаю.\nГотов идти навстречу раю,k01\nИ медлю в сумрачном краю...";
            Console.WriteLine(c);
            Console.ResetColor();
        }
    }
}