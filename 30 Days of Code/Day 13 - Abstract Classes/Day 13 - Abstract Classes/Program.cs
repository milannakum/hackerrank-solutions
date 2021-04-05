using System;

namespace Day_13___Abstract_Classes
{
    class Program
    {
        abstract class Book
        {

            protected string title;
            protected string author;

            public Book(string t, string a)
            {
                title = t;
                author = a;
            }
            public abstract void display();
        }

        class MyBook : Book
        {
            protected int price;

            public MyBook(string title, string author, int price) : base(title, author)
            {
                this.price = price;
            }

            public override void display()
            {
                Console.WriteLine($"Title: {title}\nAuthor: {author}\nPrice: {price}");
            }
        }

        static void Main(string[] args)
        {
            String title = Console.ReadLine();
            String author = Console.ReadLine();
            int price = Int32.Parse(Console.ReadLine());
            Book new_novel = new MyBook(title, author, price);
            new_novel.display();
        }
    }
}