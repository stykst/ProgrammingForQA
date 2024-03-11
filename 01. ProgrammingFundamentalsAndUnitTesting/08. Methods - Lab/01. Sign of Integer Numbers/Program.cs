var n = int.Parse(Console.ReadLine());

Console.WriteLine($"The number {n} is {GetSignOfIntegerNumber(n)}.");
static string GetSignOfIntegerNumber(int n)
{
    if (n > 0) return "positive";
    else if (n < 0) return "negative";
    else return "zero";
}