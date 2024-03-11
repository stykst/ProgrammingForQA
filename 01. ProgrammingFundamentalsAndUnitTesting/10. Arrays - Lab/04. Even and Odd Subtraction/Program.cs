var arr = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

var even = 0;
var odd = 0;

foreach (var i in arr)
{
    if (i % 2 == 0) even += i;
    else odd += i;
}

Console.WriteLine(even - odd);