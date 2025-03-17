using System;
using System.Collections.Generic;
using System.Text;
namespace lab2
{
    class Program
    {
        static void Main()
        {
            Student first = new("Anna","ddd",20,2005);
            Student second = new("Борис","ddd",20,2005);

            first.Print();
            second.Print();
        }
    }
    class Student
    {
        public string name;
        public string family;
        public int age;
        public int date;
        public Student(string name, string family, int age, int date)
        {
            this.name = name;
            this.family = family;
            this.age = age;
            this.date = date;
        } 
        
        input1 = Console.ReadLine()
        switch (input1)
        {
            case 1:
            Console.WriteLine("Довавление");
            break;
        }
        public void Print() => Console.WriteLine($"Имя: {name},Фамилия: {family},Возраст: {age},Дата рождения {date}");
    }
    
    
}