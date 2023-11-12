namespace CSharpAdvanced.Delegates;

public class Book
{
    //public delegate void BookHandler(Book book);

    public int Id { get; set; }

    public int Price { get; set; }

    public string Name { get; set; }
    public Book()
    {
        Console.WriteLine("Book intialised");
    }
    
    public void Process(Action<Book> bookHandler)
    {
        bookHandler(this);
    }
        
}