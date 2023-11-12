namespace CSharpAdvanced.LambdaExpressions;

public class Calculator
{
    public void Calculate(int x, int y)
    {
        Func<int, int, int> add = (x, y) => x + y;
        Func<int, int, int> sub = (x, y) => x - y;
        Func<int, int, int> mul = (x, y) => x * y;
        Func<int, int, int> div = (x, y) => x / y;

        var resAdd = add(2, 3);
        var resSub = sub(2, 3);
        var resMul = mul(2, 3);
        var resDiv = div(2, 3);
    }
}