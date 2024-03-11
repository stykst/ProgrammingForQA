var input = Console.ReadLine()
    .Split()
    .ToArray();
    
foreach (string str in input)
{
    var repeatedString = RepeatString(str);
    Console.Write(repeatedString);
}

static string RepeatString(string input)
{
    var repeatedString = string.Empty;

    for (int i = 0; i < input.Length; i++)
    {
        repeatedString += input;
    }

    return repeatedString;
}