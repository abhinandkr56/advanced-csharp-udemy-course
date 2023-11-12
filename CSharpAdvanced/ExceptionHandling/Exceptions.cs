namespace CSharpAdvanced.ExceptionHandling;

public class Exceptions
{
    public void DivideByZero()
    {
        try
        {
            int b = 0;
            var res = 1 / b;
        }
        catch (Exception e)
        {
            ConsoleExtension.Error(e.Message);
            throw;
        }
    }
}

static class ConsoleExtension
{
    public static void Error(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ResetColor();
    }
}