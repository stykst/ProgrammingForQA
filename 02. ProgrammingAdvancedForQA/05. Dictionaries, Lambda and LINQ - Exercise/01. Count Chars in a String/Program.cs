var input = Console.ReadLine();

var charCount = CountCharacters(input);

foreach (var kvp in charCount)
{
    Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
}

static Dictionary<char, int> CountCharacters(string input)
{
    var charCount = new Dictionary<char, int>();

    foreach (char c in input)
    {
        if (c != ' ')
        {
            if (charCount.ContainsKey(c)) charCount[c]++;
            else charCount[c] = 1;
        }
    }

    return charCount;
}
