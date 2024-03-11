var input = Console.ReadLine();
var seats = int.Parse(Console.ReadLine());
var row = int.Parse(Console.ReadLine());

double output = seats * row;

switch (input)
{
    case "Premiere": output *= 12; break;
    case "Normal": output *= 7.5; break;
    default: output *= 5; break;
}

Console.WriteLine($"{output:F2}");