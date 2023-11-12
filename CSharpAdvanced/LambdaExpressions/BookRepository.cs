namespace CSharpAdvanced.LambdaExpressions;

public class BookRepository
{
    public List<Delegates.Book> Books = new List<Delegates.Book>();

    public List<Delegates.Book> GetBooks()
    {
        return new List<Delegates.Book>()
        {
            new Delegates.Book() { Id = 1, Price = 10, Name = "ABC" },
            new Delegates.Book() { Id = 2, Price = 8, Name = "DEF" },
            new Delegates.Book() { Id = 3, Price = 5, Name = "GHI" },
        };
    }

    public List<Delegates.Book> GetCheapestBooks(int maxPrice)
    {
        return GetBooks().FindAll(book =>
            book.Price < maxPrice
        );
    }
}