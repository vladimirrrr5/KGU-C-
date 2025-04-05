using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        List<Publication> items = new List<Publication>();
        while (true)
        {
            Console.WriteLine("1 - добавить книгу 2 - добавить аудиокнигу, 3 - показать все книги 4 - выйти из программы");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    items.Add(Book.Getdata());
                        break;
                case "2":
                    items.Add(Type.Getdata());
                        break;
                case "3":
                    foreach (var item in items)
                    {
                        item.Putdata();
                    }
                        break;
                case "4":
                return;
            }    
        }
    }
}
class Publication
{
    public string name { get; set; }
    public int price { get; set; }
    public Publication(string name, int price)
    {
        this.name = name;
        this.price = price;
    }
    public virtual void Putdata()
    {
        Console.WriteLine($"Название книги: {name}");
        Console.WriteLine($"цена книги: {price} руб");
    }
    public new static Publication Getdata()
    {
        Console.WriteLine("введите название книги");
        string name = Console.ReadLine();

        Console.WriteLine("введите цену книги");
        int price = int.Parse(Console.ReadLine());
        
        return new Publication(name, price);

    }
}
class Book: Publication
{
    public int page { get; set; }
    public Book(string name, int price, int page):base(name, price)
    {
        this.page = page;
    }
    public override void Putdata()
    {
        base.Putdata();
        Console.WriteLine($"Страниц: {page}");
    }
    public new static Book Getdata()
    {
        Console.WriteLine("введите название книги");
        string name = Console.ReadLine();

        Console.WriteLine("введите цену книги в рублях");
        int price = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Введите количество страниц:");
        int page = int.Parse(Console.ReadLine());
        
        return new Book(name, price, page);
    }
}
class Type: Publication
{
    public int minute{ get; set; }

    public Type(string name, int price, int minute): base (name, price)
    {
        this.minute = minute;
    }
    public override void Putdata()
    {
        base.Putdata();
        Console.WriteLine($"Кол-во минут: {minute}");
    }
    public new static Type Getdata()
    {
        Console.WriteLine("введите название книги");
        string name = Console.ReadLine();

        Console.WriteLine("введите цену книги в рублях");
        int price = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Введите количество минут:");
        int minute = int.Parse(Console.ReadLine());
        
        return new Type(name, price, minute);
    }

}

