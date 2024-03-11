var input = Console.ReadLine().ToLower();

var output = string.Empty;

switch (input)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u": output = "Vowel"; break;

    default: output = "Consonant"; break;
}

Console.WriteLine(output);