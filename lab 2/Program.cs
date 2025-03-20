using System;
using System.Collections.Generic;
using System.Text;
namespace lab2
{
    class Program
    {
        static void Main()
        {
            StudentGroup group = new StudentGroup();

            Student first = new("Anna","ddd",20,2005,01);
            Student second = new("Борис","ddd",20,2005,11);

            group.Add(first);
            group.Add(second);

            while (true)
            {
                Console.WriteLine("Введите команду (1 - Добавление,  2 - Список всех студентов,3 - Удаление, 4 - Выход):");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Student newStudent = Student.ProcessInput();
                        if (newStudent != null)
                        {
                            group.Add(newStudent);
                            Console.WriteLine("Студент добавлен.");
                        }
                        break;
                    case "2":
                        group.PrintAllStudents();
                        break;
                    case "3":
                        group.DeleteStudent();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Неизвестная команда");
                        break;
                }
            }
        }
    }   
    class Student
    {
        public string name;
        public string family;
        public int age;
        public int date;
        public int ID;
        public Student(string name, string family, int age, int date, int ID)
        // конструктор для инициализации параметров объекта
        {
            this.name = name;
            this.family = family;
            this.age = age;
            this.date = date;
            this.ID = ID;
        } 
        public static Student ProcessInput()
        {
            Console.WriteLine("Введите Имя:");
            string name = Console.ReadLine();
            Console.WriteLine("Введите фамилию:");
            string family = Console.ReadLine();
            Console.WriteLine("Введите возраст:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите год рождения:");
            int date = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите id студента");
            int ID = int.Parse(Console.ReadLine());

            return new Student(name, family, age, date, ID);
        }
        public void Print()
        {
            Console.WriteLine($"Имя: {name}, Фамилия: {family}, Возраст: {age}, Дата рождения: {date}, id {ID}");
        }
    }
    class StudentGroup
    {
        public List<Student> Students  = new List<Student>();
        public void Add(Student student)
        {
            Students.Add(student);
        }
        public void PrintAllStudents()
        {
            if (Students.Count == 0)
            {
                Console.WriteLine("Список студентов пуст.");
            }
            else
            {
                foreach (var student in Students)
                {
                    student.Print();
                }
            }
        }
        public void DeleteStudent()
        {
            Console.WriteLine("Введите ID студента");
            int idToDelete = int.Parse(Console.ReadLine());
            Student studentToRemove = null;
            foreach (var student in Students)
            {
                if (student.ID == idToDelete)
                {
                    studentToRemove = student;
                    break;
                }
            }
            if (studentToRemove != null)
            {
                Students.Remove(studentToRemove);
                Console.WriteLine("Студент удален.");
            }
        }
    }
}