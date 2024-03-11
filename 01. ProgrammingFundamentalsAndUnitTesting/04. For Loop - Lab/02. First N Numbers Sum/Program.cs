var n = int.Parse(Console.ReadLine());

var total = 0;
var numbers = string.Empty;

for (int i = 1; i <= n; i++)
{
    total += i;
    numbers += i;

    if (i < n) numbers += "+";
}

Console.WriteLine($"{numbers}={total}");