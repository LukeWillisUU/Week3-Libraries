using System.Collections.Specialized;

class Book
{
    string Title;
    string Author;
    string ISBN;
    int NoOfPages;

    void DisplayInfo()
    {
        //Output book information to the console
        Console.WriteLine("Book Information");
        Console.WriteLine("----------------------");
        Console.WriteLine($"Book Title: {Title} ");
        Console.WriteLine($"Book Author: {Author}");
        Console.WriteLine($"Book.ISBN: {ISBN}");
        Console.WriteLine($"Book.NoOfPages: {NoOfPages}");
        Console.WriteLine("-----------------------");


    }

    static void Main(string[] args)
    {
        //create new instance of the book class
        Book book = new Book();
        book.Title = "C# for beginners";
        book.Author = "Bill Gates";
        book.ISBN = "12345666";
        book.NoOfPages = 200;

        Book book2 = new Book();
        book2.Title =  "C# methods and classes";
        book2.Author = "Microsoft";
        book2.ISBN = "1234566";
        book2.NoOfPages = 50;

        //Output the book information to the console
        
        book.DisplayInfo();
        book2.DisplayInfo();


    }


}