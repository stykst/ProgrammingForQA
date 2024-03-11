var input = Console.ReadLine();

var output = string.Empty;

switch (input)
{
    case "student": output = "$1.00"; break;
    case "regular": output = "$1.60"; break;

    default: output = "Invalid ticket type!"; break;
}

Console.WriteLine(output);