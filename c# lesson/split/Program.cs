// string s = "som budy won't  tomy";

// string[] subs = s.Split(' ');
// Console.WriteLine(s);
// foreach (var sub in subs)
// {
//     Console.WriteLine(sub);
// }
using System;

class Program
{
    static void Main()
    {
        string a = "Медведь шел по лесу";
        string[] words = a.Split(' ');
        Console.WriteLine($"Тип переменной words: {a.GetType().FullName}"); // Вывод: Тип переменной words: System.String[]
        Console.WriteLine($"Базовый тип: {a.GetType().BaseType}"); // Вывод: Базовый тип: System.Array
        // Выводим второе слово
        Console.WriteLine(words[1]); // Вывод: шел

        // Выводим информацию о типе переменной words
        Console.WriteLine(words.GetType()); // Вывод: System.String[]

        // Если нужно больше информации о типе
        Console.WriteLine($"Тип переменной words: {words.GetType().FullName}"); // Вывод: Тип переменной words: System.String[]
        Console.WriteLine($"Базовый тип: {words.GetType().BaseType}"); // Вывод: Базовый тип: System.Array
    }
}