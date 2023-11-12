namespace CSharpAdvanced;

public class Book
{
    public int Id { get; set; }

    public string Name { get; set; }
}

public class BookList
{
    private List<Book> books = new List<Book>();

    public void Add(Book book)
    {
      books.Add(book);   
    }

    public Book this[int index]
    {
        get
        {
            return books[index];
        }
    }
}