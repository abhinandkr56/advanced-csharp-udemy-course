namespace CSharpAdvanced.Delegates;

public class BookActions
{
    public void Read(Book book)
    {
        Console.WriteLine("Reading");
    }
    
    public void Write(Book book)
    {
        Console.WriteLine("Writing");
    }
}