using System.Collections.Specialized;

class Book
{
    //Properties
    string Title;
    string Author;
    string ISBN;
    int NoOfPages;

    //Constructor for Book object
    //Allows to add a new instance of the book class

    public Book(string bookTitle, string bookAuthor, string bookISBN, int bookNoOfPages)
    {
        Title = bookTitle;
        Author = bookAuthor;
        ISBN = bookISBN;
        NoOfPages = bookNoOfPages;
    }

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
        Book book = new Book("C# for beginners","Bill Gates","123445", 200);
        Book book1 = new Book("Visual Studio 2022","Microsoft","123123123", 70);

        //Output the book information to the console
        
        book.DisplayInfo();
        book1.DisplayInfo();
        


    }


}