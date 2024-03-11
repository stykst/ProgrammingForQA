var season = Console.ReadLine();
var type = Console.ReadLine();
var days = int.Parse(Console.ReadLine());

double price = 0.0;

switch (season)
{
    case "Spring": price = type == "Hotel" ? 30 * days * 0.8 : 10 * days * 0.8; break;
    case "Summer": price = type == "Hotel" ? 50 * days : 30 * days; break;
    case "Autumn": price = type == "Hotel" ? 20 * days * 0.7 : 15 * days * 0.7; break;
    case "Winter": price = type == "Hotel" ? 40 * days * 0.9 : 10 * days * 0.9; break;
}

Console.WriteLine($"{price:F2}");