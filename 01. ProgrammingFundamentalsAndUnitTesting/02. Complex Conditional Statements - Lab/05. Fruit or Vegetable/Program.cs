var input = Console.ReadLine();

var output = string.Empty;

switch (input)
{
    case "banana":
    case "apple":
    case "kiwi":
    case "cherry":
    case "lemon": output = "fruit"; break;

    case "cucumber":
    case "pepper":
    case "carrot": output = "vegetable"; break;

    default: output = "unknown"; break;
}

Console.WriteLine(output);