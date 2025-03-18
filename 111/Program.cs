using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGroup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int p = 5;

        }
    }
}


public class StGr
{
    private List<Student> students = new List<Student>();

    public void Add(Student student)
    {
        students.Add(student);
    }
    public void Remove(Student student)
    {
        students.Remove(student);
    }

    public void SortByAge()
    {
    
    }
}

public class Student
{
    public string name;
    public int age;
    public string family;

    public Student()
    {
        name = "Иван";
        family = "Иванов";
        age = 20;
    }

    public Student(string name, int age, string family)
    {
        this.name = name;
        this.age = age;
        this.family = family;
    }

    public Student(Student student)
    {
        this.age=student.age;
        this.family=student.family;
        this.name = student.name;
    }
}
