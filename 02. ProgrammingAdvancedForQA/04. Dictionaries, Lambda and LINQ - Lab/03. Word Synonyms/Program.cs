var n = int.Parse(Console.ReadLine());

var synonymsDictionary = new Dictionary<string, List<string>>();

for (int i = 0; i < n; i++)
{
    var word = Console.ReadLine();
    var synonym = Console.ReadLine();

    if (!synonymsDictionary.ContainsKey(word))
    {
        synonymsDictionary[word] = new List<string>();
    }

    synonymsDictionary[word].Add(synonym);
}

foreach (var entry in synonymsDictionary)
{
    var word = entry.Key;
    var synonyms = entry.Value;

    Console.WriteLine($"{word} - {string.Join(", ", synonyms)}");
}