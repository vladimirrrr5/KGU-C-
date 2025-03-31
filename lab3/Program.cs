using System;
using System.Collections.Generic;
using System.Text;
namespace lab3
{
    class Program
    {
        static void Main()
        {
            Add adder = new Add();
            adder.Addition(5,2);
            adder.Addition(5.2f,3.2f);
            adder.Addition("Иван", "Иванов");
        }
    }
    class Add
    {
        public void Addition(int a, int b)
        {
            int res = a + b;
            Console.WriteLine(res);
        }
        public void Addition(float a, float b)
        {
            float res = a + b;
            Console.WriteLine(res);
        }
        public void Addition(string a, string b)
        {
            string res = a + b;
            Console.WriteLine(res);
        }
    }
}
