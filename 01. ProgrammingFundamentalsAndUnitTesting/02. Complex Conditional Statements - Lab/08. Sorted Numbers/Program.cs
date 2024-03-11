var a = int.Parse(Console.ReadLine());
var b = int.Parse(Console.ReadLine());
var c = int.Parse(Console.ReadLine());

var output = string.Empty;

if (a < b && b < c)
{
    output = "Ascending";
}

else if (a > b && b > c)
{
    output = "Descending";
}

else
{
    output = "Not sorted";
}

Console.WriteLine(output);