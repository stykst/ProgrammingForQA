List<double>? numbers = Console.ReadLine()
    .Split()
    .Select(double.Parse)
    .ToList();

SumAdjacentEqualNumbers(numbers);

Console.WriteLine(string.Join(" ", numbers));

static void SumAdjacentEqualNumbers(List<double> numbers)
{
    var foundEqual = true;

    while (foundEqual)
    {
        foundEqual = false;

        for (int i = 0; i < numbers.Count - 1; i++)
        {
            if (numbers[i] == numbers[i + 1])
            {
                numbers[i] += numbers[i + 1];
                numbers.RemoveAt(i + 1);
                foundEqual = true;
                break;
            }
        }
    }
}