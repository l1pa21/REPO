using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите текст на русском:");
        string text = Console.ReadLine();
        string result = TranslateToCS(text);
        Console.WriteLine("Текст на алфавите CS:");
        Console.WriteLine(result);
    }

    static string TranslateToCS(string text)
    {
        Dictionary<char, string> csAlphabet = new Dictionary<char, string>()
        {
            {'А', "A"}, {'а', "a"},
            {'Б', "6"}, {'б', "6"},
            {'В', "B"}, {'в', "B"},
            {'Г', "r"}, {'г', "r"},
            {'Д', "D"}, {'д', "D"},
            {'Е', "E"}, {'е', "e"},
            {'Ё', "E"}, {'ё', "e"},
            {'Ж', "}{"}, {'ж', "}{"},
            {'З', "3"}, {'з', "3"},
            {'И', "u"}, {'и', "u"},
            {'Й', "u"}, {'й', "u"},
            {'К', "K"}, {'к', "K"},
            {'Л', "JI"}, {'л', "JI"},
            {'М', "M"}, {'м', "M"},
            {'Н', "H"}, {'н', "H"},
            {'О', "O"}, {'о', "o"},
            {'П', "n"}, {'п', "n"},
            {'Р', "P"}, {'р', "P"},
            {'С', "C"}, {'с', "c"},
            {'Т', "T"}, {'т', "T"},
            {'У', "y"}, {'у', "y"},
            {'Ф', "qp"}, {'ф', "qp"},
            {'Х', "X"}, {'х', "x"},
            {'Ц', "u,"}, {'ц', "u,"},
            {'Ч', "4"}, {'ч', "4"},
            {'Ш', "LLI"}, {'ш', "LLI"},
            {'Щ', "LLI"}, {'щ', "LLI"},
            {'Ъ', "ъ"}, {'ъ', "ъ"},
            {'Ы', "bI"}, {'ы', "bI"},
            {'Ь', "b"}, {'ь', "b"},
            {'Э', "3"}, {'э', "3"},
            {'Ю', "|-|o"}, {'ю', "|-|o"},
            {'Я', "9I"}, {'я', "9I"}
        };

        string result = "";
        foreach (char c in text)
        {
            if (csAlphabet.ContainsKey(c))
                result += csAlphabet[c];
            else
                result += c;
        }

        return result;
    }
}