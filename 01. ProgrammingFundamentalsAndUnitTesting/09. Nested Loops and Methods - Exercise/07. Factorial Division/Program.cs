var x = int.Parse(Console.ReadLine());
var y = int.Parse(Console.ReadLine());

Console.WriteLine(CalculateFactorial(x) / CalculateFactorial(y));

static long CalculateFactorial(int n)
{
    var result = 1L;

    for (int i = 1; i <= n; i++)
    {
        result *= i;
    }

    return result;
}