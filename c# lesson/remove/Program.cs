using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        // Создаем список из пяти строк
        List<string> strings = new List<string>();
        strings.Add("Первая строка");
        strings.Add("Вторая строка");
        strings.Add("Третья строка");
        strings.Add("Четвертая строка");
        strings.Add("11 2");

        string name = "11";
        for (int i = strings.Count - 1; i >= 0; i--)
        {
            if (strings[i].Equals(name, StringComparison.Ordinal))
            {
                strings.RemoveAt(i);
            }
        }
        foreach (string item in strings)
        {
            Console.WriteLine(item);
        }
    }
}