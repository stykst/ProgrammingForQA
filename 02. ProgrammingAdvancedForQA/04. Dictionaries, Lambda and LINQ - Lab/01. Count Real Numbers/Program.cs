var numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

var occurrences = new Dictionary<int, int>();

foreach (int number in numbers)
{
    if (occurrences.ContainsKey(number)) occurrences[number]++;
    else occurrences[number] = 1;
}

Array.Sort(numbers);

foreach (int number in numbers.Distinct())
{
    Console.WriteLine($"{number} -> {occurrences[number]}");
}