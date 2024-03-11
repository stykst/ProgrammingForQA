var input = Console.ReadLine();

var output = string.Empty;

switch (input)
{
    case "curry":
    case "noodles":
    case "sushi":
    case "spaghetti":
    case "bread": output = "food"; break;

    case "tea":
    case "water":
    case "coffee":
    case "juice": output = "drink"; break;

    default: output = "unknown"; break;
}

Console.WriteLine(output);