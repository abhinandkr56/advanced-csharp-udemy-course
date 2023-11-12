namespace CSharpAdvanced.ExtensionMethods;

public static class StringExtensions
{
    public static string Shorten(this string str, int numberOfLetters)
    {
        return str.Substring(0, numberOfLetters);
    }
}

public static class EnumerableExtensions
{
    public static string GetMiddleOrDefault(this IEnumerable<string> en)
    {
        var length = en.Count();

        return en.Skip(length / 2).FirstOrDefault();
    }
}

public class ExtensionTest
{
    private string[] str = new string[3];
    public void Test()
    {
        str.GetMiddleOrDefault();
    }
}