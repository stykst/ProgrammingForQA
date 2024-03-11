var x = int.Parse(Console.ReadLine());
var y = int.Parse(Console.ReadLine());
var z = int.Parse(Console.ReadLine());

Console.WriteLine(GetSignOfIntegerNumber(x, y, z));

static string GetSignOfIntegerNumber(int x, int y, int z)
{
    var result = x * y * z;

    if (result > 0) return "positive";
    else if (result < 0) return "negative";
    else return "zero";
}