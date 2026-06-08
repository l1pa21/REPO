using System;

class Program
{
    static void Main()
    {
        string word = "коронация";

        string kor = word.Substring(0, 3); // "кор"
        string naciya = word.Substring(3);  // "онация"
        string aciya = naciya.Substring(1); // "нация"
        string ciya = aciya.Substring(1);   // "ация" -> "ция"

        string c = ciya.Substring(0, 1); // "ц"
        string i = ciya.Substring(1, 1); // "и"
        string r = kor.Substring(2, 1);  // "р"
        string k = kor.Substring(0, 1);  // "к"
        string circ = c + i + r + k;

        string o = kor.Substring(1, 1); // "о"
        string ok = o + k;              // "ок"
        string ro = r + o;              // "ро"
        string okorok = ok + ro + ok;   // "ок" + "ро" + "ок"

        Console.WriteLine($"Исходное слово: {word}");
        Console.WriteLine($"Полученное слово 'цирк': {circ}");
        Console.WriteLine($"Полученное слово 'окорок': {okorok}");
    }
}
