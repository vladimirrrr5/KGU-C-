using System;
using System.Collections.Generic;
using System.IO;

List<string> StudentList = new List<string>();


using (StreamReader sr = new StreamReader("students.txt"))
{
    string line;
    while ((line = sr.ReadLine()) != null)
    {
        StudentList.Add(line);
        
    }
}
// Выводим список студентов
Console.WriteLine("Ведите комманду              нажмите help, чтобы посмотреть команды");

string n = Console.ReadLine();

if (n == "help")
{
    Console.WriteLine("1 - Поиск по имени \n2 - поиск по фамилии \n3 поиск по возрасту \n4 - поиск по году рождения");
}
else if (n == "1")
{
    Console.WriteLine("Введите Имя");
    string name = Console.ReadLine();
    foreach (string student in StudentList)
    {
        string[] mas = student.Split(' ');
         Console.WriteLine(mas[0]);
        if (student.Contains(name))
        {
            Console.WriteLine(student);

        }

        Console.WriteLine("не найдено");


    }
   
}
else if (n == "2")
{
    Console.WriteLine("Введите Фамилию");
    string name = Console.ReadLine();
    foreach (string student in StudentList)
    {
        if (student.Contains(name))
        {
            Console.WriteLine(student);

        }

        Console.WriteLine("не найдено");


    }
}
else if (n == "3")
{
    Console.WriteLine("Введите возраст");
    string name = Console.ReadLine();
    foreach (string student in StudentList)
    {
        if (student.Contains(name))
        {
            Console.WriteLine(student);

        }

        Console.WriteLine("не найдено");


    }
}
else if (n == "4")
{
    Console.WriteLine("Введите год рождения");
    string name = Console.ReadLine();
    foreach (string student in StudentList)
    {
        if (student.Contains(name))
        {
            Console.WriteLine(student);

        }

        Console.WriteLine("не найдено");


    }
}
else
{
    Console.WriteLine("такой команды не существует");
}
