var words = Console.ReadLine().Split();

var occurrences = new Dictionary<string, int>();

foreach (string word in words)
{
    if (occurrences.ContainsKey(word)) occurrences[word]++;
    else occurrences[word] = 1;
}

var result = new HashSet<string>();

foreach (var pair in occurrences)
{
    if (pair.Value % 2 != 0)
    {
        result.Add(pair.Key.ToLower());
    }
}

foreach (string word in words)
{
    if (result.Contains(word.ToLower()))
    {
        Console.Write($"{word.ToLower()} ");
        result.Remove(word.ToLower());
    }
}