var drink = Console.ReadLine().ToLower();
var extra = Console.ReadLine().ToLower();

var price = 0.0;

switch (drink)
{
    case "coffee": price = 1.00; break;
    case "tea": price = 0.60; break;

    default: Console.WriteLine("Invalid drink name."); return;
}

if (extra == "sugar")
{
    price += 0.40;
}

else if (extra != "no")
{
    Console.WriteLine("Invalid choice for sugar.");
    return;
}

Console.WriteLine($"Final price: ${price:F2}");