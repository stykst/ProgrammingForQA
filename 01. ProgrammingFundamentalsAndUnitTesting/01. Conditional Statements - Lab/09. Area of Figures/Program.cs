var input = Console.ReadLine();

var output = string.Empty;

switch (input)
{
    case "square": output = $"{Math.Pow(double.Parse(Console.ReadLine()), 2):F2}"; break;
    case "rectangle": output = $"{double.Parse(Console.ReadLine()) * double.Parse(Console.ReadLine()):F2}"; break;
    case "circle": output = $"{Math.PI * Math.Pow(double.Parse(Console.ReadLine()), 2):F2}"; break;

    default: output = "Invalid figure."; break;
}

Console.WriteLine(output);