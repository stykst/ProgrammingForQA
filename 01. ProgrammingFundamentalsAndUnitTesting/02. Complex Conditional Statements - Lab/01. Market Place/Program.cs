var product = Console.ReadLine().ToLower();
var day = Console.ReadLine().ToLower();

var price = 0.0;

switch (product)
{
    case "banana": price = day == "weekday" ? 2.5 : 2.7; break;
    case "apple": price = day == "weekday" ? 1.3 : 1.6; break;

    default: price = day == "weekday" ? 2.2 : 3; break;
}

Console.WriteLine($"{price:F2}");