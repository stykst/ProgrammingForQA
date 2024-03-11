var words = Console.ReadLine()
    .Split()
    .Where(w => w.Length % 2 == 0);

foreach (string word in words)
{
    Console.WriteLine(word);
}