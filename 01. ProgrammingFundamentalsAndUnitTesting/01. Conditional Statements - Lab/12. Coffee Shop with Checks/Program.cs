var drink = Console.ReadLine().ToLower();
var extra = Console.ReadLine().ToLower();

var price = 0.0;

switch (drink)
{
    case "coffee": price = 1.00; break;
    case "tea": price = 0.60; break;

    default: Console.WriteLine("Unknown drink"); return;
}

if (extra == "sugar")
{
    price += 0.40;
}

else if (extra != "no")
{
    Console.WriteLine("Unknown extra");
    return;
}

Console.WriteLine($"Final price: ${price:F2}");