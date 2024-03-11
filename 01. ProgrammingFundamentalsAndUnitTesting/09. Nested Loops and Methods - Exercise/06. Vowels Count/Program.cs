var text = Console.ReadLine().ToLower();

var count = 0;

foreach (char c in text)
{
    if ("aeiou".Contains(c)) count++;
}

Console.WriteLine(count);