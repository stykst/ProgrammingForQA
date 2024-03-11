var numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

while (numbers.Count > 1)
{
    var condensedNumbers = new List<int>();

    for (int i = 0; i < numbers.Count - 1; i++)
    {
        int sum = numbers[i] + numbers[i + 1];
        condensedNumbers.Add(sum);
    }

    numbers = condensedNumbers;
}

Console.WriteLine(numbers[0]);